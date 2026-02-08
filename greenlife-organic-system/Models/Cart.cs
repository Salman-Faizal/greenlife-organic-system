using System.Collections.Generic;
using System.Linq;

namespace greenlife_organic_system.Models
{
    public class Cart
    {
        public List<OrderItem> Items { get; private set; }

        public Cart()
        {
            Items = new List<OrderItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            OrderItem existing = Items
                .FirstOrDefault(i => i.Product.ProductId == product.ProductId);

            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                Items.Add(new OrderItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }

        public void RemoveItem(string productId)
        {
            OrderItem item = Items
                .FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
                Items.Remove(item);
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.GetSubtotal());
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
