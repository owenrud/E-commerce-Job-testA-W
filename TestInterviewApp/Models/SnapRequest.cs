namespace TestInterviewApp.Models
{
    public class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
    public class SnapRequest
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
        public Customer Customer { get; set; }
    }
}
