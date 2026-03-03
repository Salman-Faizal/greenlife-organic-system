using System.Collections.Generic;
using System.Linq;

namespace greenlife_organic_system.Models
{
    // Represents a temporary shopping cart for a customer session.
    // The cart holds OrderItem objects before checkout.
    public class Cart
    {
        // Collection of items currently added to the cart
        // Private setter ensures encapsulation (cannot be replaced externally).
        public List<OrderItem> Items { get; private set; }

        public Cart()
        {
            Items = new List<OrderItem>();
        }

        // Adds a product to the cart.
        // If the product already exists in the cart, its quantity is incremented.
        // Otherwise, a new OrderItem is created and added to the list.
        public void AddItem(Product product, int quantity)
        {
            // Search for existing item with the same ProductId (Linear search via LINQ)
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

        // Removes a product from the cart using its ProductId.
        // If the item exists, it is removed from the list.
        public void RemoveItem(string productId)
        {
            OrderItem item = Items
                .FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
                Items.Remove(item);
        }

        // Calculates the total value of all items in the cart.
        // Uses LINQ Sum() to aggregate subtotals.
        public decimal GetTotal()
        {
            return Items.Sum(i => i.GetSubtotal());
        }

        // Clears all items from the cart.
        // used after successful checkout.
        public void Clear()
        {
            Items.Clear();
        }
    }
}
