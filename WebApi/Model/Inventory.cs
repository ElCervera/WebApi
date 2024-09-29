namespace WebApi.Model
{
    public class Inventory
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ICollection<PurchaseInventory> PurchaseInventories { get; set; }
        public ICollection<AppointmentPart> AppointmentParts { get; set; }
    }
}
