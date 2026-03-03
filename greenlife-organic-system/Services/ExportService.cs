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
            DateTime? fromDate = null,  // Optional
            DateTime? toDate = null)
        {
            // StringBuilder is used for efficient string concatenation, since strings in C# are immutable
            StringBuilder sb = new StringBuilder();

            // report header
            sb.AppendLine("GreenLife Organic Store - Order History Report");

            // Optional date filtering metadata (does not filter here, only displays range)
            if (fromDate.HasValue && toDate.HasValue)
            {
                sb.AppendLine(
                    $"Date Range: {fromDate.Value:yyyy-MM-dd} to {toDate.Value:yyyy-MM-dd}");
            }

            sb.AppendLine(); // Empty line
            sb.AppendLine("OrderId,CustomerId,OrderDate,Status,Total");

            foreach (var order in orders)
            {
                sb.AppendLine(
                    $"{Escape(order.OrderId)}," +  // Using Escape() for string fields that may contain commas or quotes.
                    $"{Escape(order.CustomerId)}," +
                    $"{order.OrderDate:yyyy-MM-dd}," +
                    $"{Escape(order.Status)}," +
                    $"{order.CalculateTotal():0.00}"
                );
            }

            // Writes entire CSV content in a single I/O operation
            File.WriteAllText(filePath, sb.ToString());
        }

        // Ensures CSV validity by escaping quotes and wrapping values
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
