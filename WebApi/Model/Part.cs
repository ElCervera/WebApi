namespace WebApi.Model
{
    public class Part
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<AppointmentPart> AppointmentParts { get; set; }
    }
}
