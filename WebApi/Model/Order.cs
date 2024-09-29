namespace WebApi.Model
{
    public class Order
    {
        public long Id { get; set; }
        public long VehicleId { get; set; }
        public long EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public required string Status { get; set; }

        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
