using greenlife_organic_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace greenlife_organic_system.Models
{
    // Represents a completed transaction made by a customer.
    // Manages order identity, ownership, lifecycle state, and total calculation.
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
            Status = "Pending"; // initial state is set to 'Pending'
            Items = new List<OrderItem>();
        }

        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.GetSubtotal());
        }
    }
}
