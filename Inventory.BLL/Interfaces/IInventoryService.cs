using Inventory.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BLL.Interfaces
{
    public interface IInventoryService
    {
        Task<List<ReportDeliveryDataDto>> GetDeliveryReportAsync(DateTime startDate, DateTime finishDate);

        IEnumerable<ProductDto> GetAllProducts();

        Task CreateDeliveryAsync(CreateDeliveryDto model);
    }
}