namespace WebApi.Model
{
    public class MaintenanceHistory
    {
        public long Id { get; set; }
        public long VehicleId { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
