namespace WebApi.Model
{
    public class Mechanic
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
