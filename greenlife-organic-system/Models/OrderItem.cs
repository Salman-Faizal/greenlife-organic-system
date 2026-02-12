using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife_organic_system.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public bool IsReviewed { get; set; } = false;

        public decimal GetSubtotal()
        {
            if (Product == null || Quantity <= 0)
                return 0;

            return Product.GetDiscountedPrice() * Quantity;
        }
    }
}
