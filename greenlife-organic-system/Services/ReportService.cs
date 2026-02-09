using System;
using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;

namespace greenlife_organic_system.Services
{
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

        public Dictionary<DateTime, decimal> GetDailySales(List<Order> orders)
        {
            return orders
                .GroupBy(o => o.OrderDate.Date)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(o => o.CalculateTotal())
                );
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
    }
}
