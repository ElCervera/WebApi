namespace WebApi.Model
{
    public class AppointmentService
    {
        public long AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!; 

        public long ServiceId { get; set; }
        public Service Service { get; set; } = null!; 
    }
}
