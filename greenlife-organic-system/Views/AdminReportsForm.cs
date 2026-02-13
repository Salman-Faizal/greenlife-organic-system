using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using greenlife_organic_system.Services;
using greenlife_organic_system.Models;


namespace greenlife_organic_system.Views
{
    public partial class AdminReportsForm : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly ReportService _reportService;
        private readonly ExportService _exportService;
        private readonly UserService _userService;

        public AdminReportsForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _orderService = new OrderService(_productService);
            _reportService = new ReportService();
            _exportService = new ExportService();
            _userService = new UserService();

            ConfigureCharts();
            ConfigureCustomerHistoryGrid();
            btnGenerate.Click += btnGenerate_Click;

        }

        public AdminReportsForm(
            ProductService productService,
            OrderService orderService,
            UserService? userService = null)
        {
            InitializeComponent();

            _productService = productService;
            _orderService = orderService;
            _reportService = new ReportService();
            _exportService = new ExportService();
            _userService = userService ?? new UserService();

            ConfigureCharts();
            ConfigureCustomerHistoryGrid();
            btnGenerate.Click += btnGenerate_Click;
        }
        private void AdminReportsForm_Load(object sender, EventArgs e)
        {
            lblCustomerOrders.Text = "Customer Order History";
            lblTotalRevenueValue.Text = "0.00";
            lblAverageOrderValue.Text = "0.00";
        }

        private void ConfigureCharts()
        {
            ConfigureSalesChart();
            ConfigureStockChart();
            ConfigureTopSellingChart();
            ConfigureStatusPieChart();

        }
        private void ConfigureSalesChart()
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();

            ChartArea salesArea = new ChartArea("SalesArea");
            salesArea.AxisX.Title = "Date";
            salesArea.AxisY.Title = "Sales Amount";
            salesArea.AxisX.Interval = 1;
            salesArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            salesArea.AxisX.LabelStyle.Format = "dd MMM";
            salesArea.AxisX.LabelStyle.Angle = -45;
            salesArea.AxisX.MajorGrid.Enabled = false;
            salesArea.AxisX.ScaleView.Zoomable = true;
            salesArea.CursorX.IsUserEnabled = true;
            salesArea.CursorX.IsUserSelectionEnabled = true;

            chartSales.ChartAreas.Add(salesArea);

            Series salesSeries = new Series("Daily Sales")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                XValueType = ChartValueType.Date
            };

            chartSales.Series.Add(salesSeries);
        }

        private void ConfigureStockChart()
        {
            chartStock.Series.Clear();
            chartStock.ChartAreas.Clear();

            ChartArea stockArea = new ChartArea("StockArea");
            stockArea.AxisX.Title = "Product";
            stockArea.AxisY.Title = "Stock Quantity";
            stockArea.AxisX.Interval = 1;
            stockArea.AxisX.LabelStyle.Angle = -45;
            stockArea.AxisX.MajorGrid.Enabled = false;
            
            chartStock.ChartAreas.Add(stockArea);

            Series stockSeries = new Series("Stock Levels")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                IsXValueIndexed = true
            };

            chartStock.Series.Add(stockSeries);
 
            stockArea.AxisY.StripLines.Clear();
            stockArea.AxisY.StripLines.Add(new StripLine
            {
                Interval = 0,
                IntervalOffset = 5,
                StripWidth = 0,
                BorderColor = Color.Red,
                BorderWidth = 2,
                Text = string.Empty
            });
        }

        private void ConfigureTopSellingChart()
        {
            chartTopSelling.Series.Clear();
            chartTopSelling.ChartAreas.Clear();

            ChartArea area = new ChartArea("TopSellingArea");
            area.AxisX.Title = "Product";
            area.AxisY.Title = "Quantity Sold";
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false;

            chartTopSelling.ChartAreas.Add(area);

            Series series = new Series("Top Selling")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                IsXValueIndexed = true
            };

            chartTopSelling.Series.Add(series);
        }

        private void ConfigureStatusPieChart()
        {
            chartOrderStatus.Series.Clear();
            chartOrderStatus.ChartAreas.Clear();
            chartOrderStatus.Legends.Clear();

            ChartArea area = new ChartArea("StatusArea");
            chartOrderStatus.ChartAreas.Add(area);

            Legend legend = new Legend("StatusLegend");
            chartOrderStatus.Legends.Add(legend);

            Series series = new Series("Order Status Distribution")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,
                Legend = "StatusLegend"
            };

            chartOrderStatus.Series.Add(series);
        }

        private void ConfigureCustomerHistoryGrid()
        {
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerOrders.MultiSelect = false;
            dgvCustomerOrders.AutoGenerateColumns = true;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            if (from > to)
            {
                MessageBox.Show("From date cannot be after To date.");
                return;
            }

            List<Order> orders = _orderService.GetAllOrders();
            List<Order> filteredOrders = _reportService.GetOrdersByDateRange(orders, from, to);

            DrawSalesChart(filteredOrders);
            DrawStockChart();
            DrawTopSellingChart(filteredOrders);
            DrawOrderStatusPieChart(filteredOrders);
            UpdateRevenueSummary(filteredOrders);
            LoadCustomerOrderHistory(orders);
        }

        private void DrawSalesChart(List<Order> orders)
        {
            var dailySales = _reportService.GetDailySales(orders);
            var orderedDates = dailySales.Keys.OrderBy(date => date).ToList();

            Series series = chartSales.Series[0];
            series.Points.Clear();

            foreach (var entry in dailySales.OrderBy(d => d.Key))
            {
                DataPoint point = new DataPoint
                {
                    XValue = entry.Key.ToOADate(),
                    YValues = new[] { (double)entry.Value }
                };

                series.Points.Add(point);
            }

            AdjustSalesAxisForDataDensity(orderedDates);
            chartSales.ChartAreas[0].RecalculateAxesScale();
        }

        private void DrawStockChart()
        {
            var stockLevels = _reportService.GetStockLevels(_productService.Products);

            Series series = chartStock.Series[0];
            series.Points.Clear();

            foreach (var item in stockLevels)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chartStock.ChartAreas[0].RecalculateAxesScale();
        }

        private void DrawTopSellingChart(List<Order> orders)
        {
            var topSelling = _reportService.GetTopSellingProductsByQuantity(orders, 5);

            Series series = chartTopSelling.Series[0];
            series.Points.Clear();

            foreach (var entry in topSelling)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chartTopSelling.ChartAreas[0].RecalculateAxesScale();
        }

        private void DrawOrderStatusPieChart(List<Order> orders)
        {
            var statusDistribution = _reportService.GetOrderStatusDistribution(orders);

            Series series = chartOrderStatus.Series[0];
            series.Points.Clear();

            foreach (var entry in statusDistribution)
            {
                DataPoint point = new DataPoint
                {
                    AxisLabel = entry.Key,
                    YValues = new[] { (double)entry.Value },
                    LegendText = entry.Key
                };

                series.Points.Add(point);
            }
        }

        private void UpdateRevenueSummary(List<Order> orders)
        {
            RevenueSummary summary = _reportService.GetRevenueSummary(orders);
            lblTotalRevenueValue.Text = summary.TotalRevenue.ToString("0.00");
            lblAverageOrderValue.Text = summary.AverageOrderValue.ToString("0.00");
        }

        private void LoadCustomerOrderHistory(List<Order> orders)
        {
            string username = txtUsername.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblCustomerOrders.Text = "Customer Order History";
                dgvCustomerOrders.DataSource = null;
                return;
            }

            CustomerOrderHistoryResult history = _reportService.GetCustomerOrderHistory(
                orders,
                _userService.Customers,
                username);

            if (!history.CustomerExists)
            {
                lblCustomerOrders.Text = "Customer Order History";
                dgvCustomerOrders.DataSource = null;
                MessageBox.Show("No customer was found for the provided username.");
                return;
            }

            lblCustomerOrders.Text = $"{history.CustomerDisplayName}'s Order History";
            dgvCustomerOrders.DataSource = history.Orders
                .Select(o => new
                {
                    o.OrderId,
                    Date = o.OrderDate,
                    o.Status,
                    Total = o.CalculateTotal()
                })
                .ToList();
        }

        private void AdjustSalesAxisForDataDensity(IReadOnlyList<DateTime> orderedDates)
        {
            ChartArea area = chartSales.ChartAreas[0];
            int pointCount = orderedDates.Count;

            if (pointCount == 0)
            {
                area.AxisX.Interval = 1;
                area.AxisX.IntervalType = DateTimeIntervalType.Days;
                area.AxisX.LabelStyle.Format = "dd MMM";
                return;
            }

            DateTime minDate = orderedDates.First();
            DateTime maxDate = orderedDates.Last();
            double spanDays = (maxDate - minDate).TotalDays;

            DateTimeIntervalType intervalType;
            int interval;

            if (spanDays <= 31)
            {
                intervalType = DateTimeIntervalType.Days;
                interval = Math.Max(1, (int)Math.Ceiling(pointCount / 10.0));
                area.AxisX.LabelStyle.Format = "dd MMM";
            }
            else if (spanDays <= 180)
            {
                intervalType = DateTimeIntervalType.Weeks;
                interval = 1;
                area.AxisX.LabelStyle.Format = "dd MMM";
            }
            else if (spanDays <= 730)
            {
                intervalType = DateTimeIntervalType.Months;
                interval = 1;
                area.AxisX.LabelStyle.Format = "MMM yy";
            }
            else
            {
                intervalType = DateTimeIntervalType.Months;
                interval = 3;
                area.AxisX.LabelStyle.Format = "MMM yy";
            }

            area.AxisX.Interval = interval;
            area.AxisX.IntervalType = intervalType;
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "OrderReport.csv"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            var orders = _orderService.GetAllOrders();
            var filteredOrders = _reportService.GetOrdersByDateRange(
                orders, from, to);

            _exportService.ExportOrdersToCsv(
                filteredOrders, dialog.FileName, from, to);

            MessageBox.Show("Report exported successfully.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
