using System;
using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;

namespace greenlife_organic_system.Services
{
    public class RevenueSummary
    {
        public decimal TotalRevenue { get; set; }
        public decimal AverageOrderValue { get; set; }
        public int IncludedOrderCount { get; set; }
    }

    public class CustomerOrderHistoryResult
    {
        public bool CustomerExists { get; set; }
        public string CustomerDisplayName { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    public class ReportService
    {
        /* ------------------ Date Filtered Orders ------------------ */

        public List<Order> GetOrdersByDateRange(
            List<Order> orders,
            DateTime startDate,
            DateTime endDate)
        {
            return orders
                .Where(o => o.OrderDate.Date >= startDate.Date
                         && o.OrderDate.Date <= endDate.Date)
                .ToList();
        }

        /* ------------------ Sales Summary ------------------ */

        public decimal GetTotalSales(List<Order> orders)
        {
            return orders.Sum(o => o.CalculateTotal());
        }

        public RevenueSummary GetRevenueSummary(List<Order> orders)
        {
            var deliveredOrders = orders
                .Where(o => string.Equals(o.Status, "Delivered", StringComparison.OrdinalIgnoreCase))
                .ToList();

            decimal totalRevenue = deliveredOrders.Sum(o => o.CalculateTotal());
            int orderCount = deliveredOrders.Count;

            return new RevenueSummary
            {
                TotalRevenue = totalRevenue,
                IncludedOrderCount = orderCount,
                AverageOrderValue = orderCount > 0
                    ? totalRevenue / orderCount
                    : 0m
            };
        }

        public Dictionary<DateTime, decimal> GetDailySales(List<Order> orders)
        {
            return orders
                .Where(o => !string.Equals(o.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
                .GroupBy(o => o.OrderDate.Date)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(o => o.CalculateTotal())
                );
        }

        public Dictionary<string, int> GetTopSellingProductsByQuantity(List<Order> orders, int topCount = 5)
        {
            return orders
                .Where(o => !string.Equals(o.Status, "Cancelled", StringComparison.OrdinalIgnoreCase))
                .SelectMany(o => o.Items ?? new List<OrderItem>())
                .Where(i => i?.Product != null)
                .GroupBy(i => i.Product.Name)
                .Select(g => new
                {
                    ProductName = g.Key,
                    TotalQuantity = g.Sum(i => i.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .Take(topCount)
                .ToDictionary(x => x.ProductName, x => x.TotalQuantity);
        }

        public Dictionary<string, int> GetOrderStatusDistribution(List<Order> orders)
        {
            return orders
                .GroupBy(o => string.IsNullOrWhiteSpace(o.Status) ? "Unknown" : o.Status)
                .ToDictionary(g => g.Key, g => g.Count());
        }


        /* ------------------ Stock Summary ------------------ */

        public Dictionary<string, int> GetStockLevels(List<Product> products)
        {
            return products
                .ToDictionary(
                    p => p.Name,
                    p => p.Stock
                );
        }

        public CustomerOrderHistoryResult GetCustomerOrderHistory(
            List<Order> orders,
            List<Customer> customers,
            string username)
        {
            string normalizedUsername = username?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(normalizedUsername))
            {
                return new CustomerOrderHistoryResult
                {
                    CustomerExists = true
                };
            }

            Customer customer = customers.FirstOrDefault(c =>
                string.Equals(c.Username, normalizedUsername, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                return new CustomerOrderHistoryResult
                {
                    CustomerExists = false
                };
            }

            return new CustomerOrderHistoryResult
            {
                CustomerExists = true,
                CustomerDisplayName = customer.Username,
                Orders = orders
                    .Where(o => o.CustomerId == customer.UserId)
                    .OrderByDescending(o => o.OrderDate)
                    .ToList()
            };
        }
    }
}
