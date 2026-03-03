using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife_organic_system.Models
{
    // Represents a single product entry within an Order.
    // Acts as a junction between Order and Product.
    // Stores quantity and review status for that specific purchase.
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public bool IsReviewed { get; set; } = false;

        public decimal GetSubtotal()
        {
            // Defensive check: ensure product exists and quantity is valid
            if (Product == null || Quantity <= 0)
                return 0;

            // Delegates price logic to Product class (encapsulation)
            return Product.GetDiscountedPrice() * Quantity;
        }
    }
}
