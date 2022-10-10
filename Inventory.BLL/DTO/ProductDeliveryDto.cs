namespace Inventory.BLL.DTO
{
    public class ProductDeliveryDto
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long DeliveryId { get; set; }

        public short Weight { get; set; }

        public decimal Cost { get; set; }
    }
}
