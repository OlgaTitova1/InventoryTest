using AutoMapper;
using Inventory.BLL.DTO;
using Inventory.BLL.Interfaces;
using Inventory.BLL.Services;
using Inventory.DAL.Context;
using Inventory.DAL.Interfaces;
using Inventory.DAL.Repositories;
using Unity;
using Unity.Lifetime;

namespace InventoryTest
{
    static partial class Program
    {
        private static void ConfigureAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>()
                    .ForMember(destination => destination.ProductId, opts => opts.MapFrom(source => source.Id));
                cfg.CreateMap<ProductDelivery, ProductDeliveryDto>();
            });
        }

        private static void ConfigureDI()
        {
            container = new UnityContainer();

            container.RegisterType<InventoriesEntities>();

            container.RegisterType<IProductRepository, ProductRepository>(new TransientLifetimeManager());
            container.RegisterType<IDeliveryRepository, DeliveryRepository>(new TransientLifetimeManager());
            container.RegisterType<IProductSupplierInfoRepository, ProductSupplierInfoRepository>(new TransientLifetimeManager());
            container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
            container.RegisterType<IInventoryService, InventoryService>(new TransientLifetimeManager());
        }
    }
}
