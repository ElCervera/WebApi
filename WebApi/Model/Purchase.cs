namespace WebApi.Model
{
    public class Purchase
    {
        public long Id { get; set; }
        public long? SupplierId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        public Supplier Supplier { get; set; }
        public ICollection<PurchaseInventory> PurchaseInventories { get; set; }
    }
}
