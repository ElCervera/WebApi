namespace WebApi.Model
{
    public class Vehicle
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public required string LicensePlate { get; set; }

        public Client Client { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<MaintenanceHistory> MaintenanceHistories { get; set; }
    }
}
