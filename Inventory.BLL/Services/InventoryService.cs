using AutoMapper;
using Inventory.BLL.DTO;
using Inventory.BLL.Interfaces;
using Inventory.DAL.Context;
using Inventory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.BLL.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IProductRepository productRepository;
        private readonly IDeliveryRepository deliveryRepository;
        private readonly IProductSupplierInfoRepository productSupplierInfoRepository;
        private readonly ISupplierRepository supplierRepository;

        public InventoryService(
            IProductRepository productRepository,
            IDeliveryRepository deliveryRepository,
            IProductSupplierInfoRepository productSupplierInfoRepository,
            ISupplierRepository supplierRepository)
        {
            this.productRepository = productRepository;
            this.deliveryRepository = deliveryRepository;
            this.productSupplierInfoRepository = productSupplierInfoRepository;
            this.supplierRepository = supplierRepository;
        }

        public async Task<List<ReportDeliveryDataDto>> GetDeliveryReportAsync(DateTime startDate, DateTime finishDate)
        {
            var supplierGroups = deliveryRepository.GetAll().ToList()
                .Where(x => x.DeliveryDate.Date >= startDate.Date && x.DeliveryDate.Date <= finishDate.Date)
                .GroupBy(x => x.SupplierId);

            var reportData = new List<ReportDeliveryDataDto>();
            
            foreach (var supplierGroup in supplierGroups)
            {
                var supplier = await supplierRepository.GetByIdAsync(supplierGroup.Key);
                var productGroups = supplierGroup
                    .SelectMany(x => x.ProductDeliveries)
                    .GroupBy(x => x.ProductId)
                    .Select(products =>
                    new ReportDeliveryDataDto
                    {
                        Weight = (short)products.Sum(x => x.Weight),
                        Cost = products.Sum(x => x.Cost),
                        ProductName = products.FirstOrDefault().Products.Name,
                        SupplierId = supplierGroup.Key,
                        SupplierName = supplier?.Name
                    }).ToList();
                reportData.AddRange(productGroups);
            }
            return reportData;
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = productRepository.GetAll().ToList();
            var productsDto = Mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public async Task CreateDeliveryAsync(CreateDeliveryDto model)
        {
            var productDeliveries = new List<ProductDelivery>();

            foreach (var product in model.Products)
            {
                var productSupplierInfo = await productSupplierInfoRepository
                    .GetSingleOrDefaultAsync(x => x.ProductId == product.ProductId && x.SupplierId == model.SupplierId);
                
                if (productSupplierInfo == null)
                {
                    continue;
                }

                var productDelivery = new ProductDelivery
                {
                    ProductId = product.ProductId,
                    Weight = product.Weight,
                    Cost = productSupplierInfo.Price * product.Weight
                };
                productDeliveries.Add(productDelivery);
            }

            var delivery = new Delivery
            {
                SupplierId = model.SupplierId,
                DeliveryDate = DateTime.Now,
                ProductDeliveries = productDeliveries
            };

            deliveryRepository.Add(delivery);
            await deliveryRepository.SaveChangesAsync();
        }
    }
}
