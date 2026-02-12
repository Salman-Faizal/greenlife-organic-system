using greenlife_organic_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace greenlife_organic_system.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // Pending, Shipped, Delivered, or Cancelled
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            OrderDate = DateTime.Now;
            Status = "Pending";
            Items = new List<OrderItem>();
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.GetSubtotal());
        }
    }
}
