using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;
using greenlife_organic_system.Data;

namespace greenlife_organic_system.Services
{
    public class OrderService
    {
        private const string OrderFile = @"DataFiles\orders.json";
        private List<Order> Orders;

        private readonly ProductService _productService;

        public OrderService(ProductService productService)
        {
            _productService = productService;
            Orders = JsonDataManager.LoadFromFile<Order>(OrderFile);
        }

        /* ------------------ Place Order ------------------ */

        public bool PlaceOrder(Customer customer, Cart cart)
        {
            if (customer == null || cart == null || cart.Items.Count == 0)
                return false;

            // Stock is already reserved when items are added to cart.
            // Verifying that cart quantities are still valid before finalizing.
            bool invalidCartState = cart.Items.Any(item =>
                item == null
                || item.Product == null
                || item.Quantity <= 0);

            if (invalidCartState)
                return false;

            // Ensuring product records still exist; checkout cannot continue otherwise.
            bool missingProduct = cart.Items.Any(item =>
                !_productService.Products.Any(p => p.ProductId == item.Product.ProductId));

            if (missingProduct)
                return false;

            Order order = new Order
            {
                CustomerId = customer.UserId,
                Items = cart.Items.ToList()
            };

            Orders.Add(order);
            SaveOrders();

            cart.Clear();
            return true;
        }

        /* ------------------ Order Queries ------------------ */

        public List<Order> GetOrdersByCustomer(string customerId)
        {
            return Orders
                .Where(o => o.CustomerId == customerId)
                .ToList();
        }

        public List<Order> GetAllOrders()
        {
            return Orders;
        }

        /* ------------------ Admin Operations ------------------ */

        public bool UpdateOrderStatus(string orderId, string newStatus)
        {
            Order order = Orders
                .FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
                return false;

            order.Status = newStatus;
            SaveOrders();
            return true;
        }

        public bool CancelPendingOrder(string orderId, string customerId)
        {
            Order order = Orders.FirstOrDefault(o =>
                o.OrderId == orderId
                && o.CustomerId == customerId);

            if (order == null)
                return false;

            if (!string.Equals(order.Status, "Pending", System.StringComparison.OrdinalIgnoreCase))
                return false;

            foreach (OrderItem item in order.Items ?? new List<OrderItem>())
            {
                if (item?.Product == null || item.Quantity <= 0)
                    continue;

                // If the product no longer exists in the catalog,
                // stock cannot be restored and we continue safely.
                _productService.IncreaseStock(item.Product.ProductId, item.Quantity);
            }

            order.Status = "Cancelled";
            SaveOrders();
            return true;
        }

        /* ------------------ Database save ------------------ */

        public void SaveOrders()
        {
            JsonDataManager.SaveToFile(OrderFile, Orders);
        }
    }
}
