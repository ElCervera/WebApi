namespace WebApi.Model
{
    public class Appointment
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long ClientId { get; set; }
        public long VehicleId { get; set; }
        public long MechanicId { get; set; }

        public Client Client { get; set; } = null!; 
        public Vehicle Vehicle { get; set; } = null!;
        public Mechanic Mechanic { get; set; } = null!;
        public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();
        public ICollection<AppointmentPart> AppointmentParts { get; set; } = new List<AppointmentPart>();
    }
}
