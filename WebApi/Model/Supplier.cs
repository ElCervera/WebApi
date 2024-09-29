namespace WebApi.Model
{
    public class Supplier
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }
}
