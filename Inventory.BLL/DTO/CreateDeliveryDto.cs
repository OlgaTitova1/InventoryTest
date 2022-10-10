using System.Collections.Generic;

namespace Inventory.BLL.DTO
{
    public class CreateDeliveryDto
    {
        public long SupplierId { get; set; }

        public IList<DeliveryProductDto> Products { get; set; }
    }
}
