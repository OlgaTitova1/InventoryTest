namespace Inventory.BLL.DTO
{
    public class ReportDeliveryDataDto
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public short Weight { get; set; }
        public decimal Cost { get; set; }

    }
}
