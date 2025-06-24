namespace TestInterviewApp.Models
{
    public class SnapRequest
    {
        public string OrderId { get; set; }
        public int Amount { get; set; }

        public CustomerDetails Customer { get; set; }

        public class CustomerDetails
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
        }
    }

}
