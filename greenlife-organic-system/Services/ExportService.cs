using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using greenlife_organic_system.Models;

namespace greenlife_organic_system.Services
{
    public class ExportService
    {
        public void ExportOrdersToCsv(
            List<Order> orders,
            string filePath,
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            StringBuilder sb = new StringBuilder();

            // report header
            sb.AppendLine("GreenLife Organic Store - Order History Report");

            if (fromDate.HasValue && toDate.HasValue)
            {
                sb.AppendLine(
                    $"Date Range: {fromDate.Value:yyyy-MM-dd} to {toDate.Value:yyyy-MM-dd}");
            }

            sb.AppendLine();
            sb.AppendLine("OrderId,CustomerId,OrderDate,Status,Total");

            foreach (var order in orders)
            {
                sb.AppendLine(
                    $"{Escape(order.OrderId)}," +
                    $"{Escape(order.CustomerId)}," +
                    $"{order.OrderDate:yyyy-MM-dd}," +
                    $"{Escape(order.Status)}," +
                    $"{order.CalculateTotal():0.00}"
                );
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private string Escape(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            // Escape commas and quotes for CSV
            value = value.Replace("\"", "\"\"");
            return value.Contains(",") ? $"\"{value}\"" : value;
        }
    }
}
