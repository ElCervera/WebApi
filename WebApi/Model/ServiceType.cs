namespace WebApi.Model
{
    public class ServiceType
    {
        public long Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
