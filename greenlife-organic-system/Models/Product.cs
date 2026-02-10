using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife_organic_system.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
        public double DiscountPercentage { get; set; }
        public int Rating { get; set; } = 0;   // 0 = no ratings yet
        public string ImagePath { get; set; }  // relative path
        public List<Review> Reviews { get; set; } = new();
        public int RatingCount { get; set; } = 0;

        public Product()
        {
            ProductId = System.Guid.NewGuid().ToString();
        }

        public decimal GetDiscountedPrice()
        {
            return Price - (Price * (decimal)(DiscountPercentage / 100));
        }
    }
}
