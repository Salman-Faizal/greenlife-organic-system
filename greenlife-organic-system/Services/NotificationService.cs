using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;

namespace greenlife_organic_system.Services
{
    public class NotificationService
    {
        private const int LowStockThreshold = 5;    

        // Returns a list of products with stock less than or equal to the defined threshold.
        public List<Product> GetLowStockProducts(List<Product> products)
        {
            return products
                .Where(p => p.Stock <= LowStockThreshold)
                .ToList();
        }
    }
}
