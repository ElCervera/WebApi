namespace WebApi.Model
{
    public class PurchaseInventory
    {
        public long Id { get; set; }
        public long PurchaseId { get; set; }
        public long InventoryId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Purchase Purchase { get; set; }
        public Inventory Inventory { get; set; }
    }
}
