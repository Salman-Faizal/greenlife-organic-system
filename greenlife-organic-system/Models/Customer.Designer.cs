namespace greenlife_organic_system.Models
{
    public class Customer : User
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customer()
        {
        }

        public string Role => "Customer";
    }
}
