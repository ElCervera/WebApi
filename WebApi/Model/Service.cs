namespace WebApi.Model
{
    public class Service
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }

        public required ICollection<AppointmentService> AppointmentServices { get; set; }
        public long ServiceTypeId { get; set; }
        public required ServiceType ServiceType { get; set; }
    }
}
