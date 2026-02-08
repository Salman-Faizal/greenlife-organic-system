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
            if (cart.Items.Count == 0)
                return false;

            // Check stock availability
            foreach (var item in cart.Items)
            {
                if (item.Product.Stock < item.Quantity)
                    return false;
            }

            // Reduce stock
            foreach (var item in cart.Items)
            {
                _productService.ReduceStock(
                    item.Product.ProductId,
                    item.Quantity
                );
            }

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

        /* ------------------ Persistence ------------------ */

        private void SaveOrders()
        {
            JsonDataManager.SaveToFile(OrderFile, Orders);
        }
    }
}
