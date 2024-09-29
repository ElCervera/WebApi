namespace WebApi.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
