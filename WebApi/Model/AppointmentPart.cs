namespace WebApi.Model
{
    public class AppointmentPart
    {
        public long AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!; 

        public long PartId { get; set; }
        public Part Part { get; set; } = null!; 
    }
}
