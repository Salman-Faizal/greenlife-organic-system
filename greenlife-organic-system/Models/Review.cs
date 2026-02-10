using System;

namespace greenlife_organic_system.Models
{
    public class Review
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
