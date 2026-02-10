using System;

namespace greenlife_organic_system.Models
{
    public class Review
    {
        public string CustomerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
