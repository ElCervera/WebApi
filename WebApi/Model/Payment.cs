namespace WebApi.Model
{
    public class Payment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        public Order Order { get; set; }
    }
}
