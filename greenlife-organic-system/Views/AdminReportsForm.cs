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


namespace greenlife_organic_system.Views
{
    public partial class AdminReportsForm : Form
    {
        public AdminReportsForm()
        {
            InitializeComponent();
        }

        private void AdminReportsForm_Load(object sender, EventArgs e)
        {

        }

        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly ReportService _reportService;
        private readonly ExportService _exportService;

        public AdminReportsForm(
            ProductService productService,
            OrderService orderService)
        {
            InitializeComponent();

            _productService = productService;
            _orderService = orderService;
            _reportService = new ReportService();
            _exportService = new ExportService();

            ConfigureCharts();
        }

        private void ConfigureCharts()
        {
            // Sales chart
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();
            chartSales.ChartAreas.Add(new ChartArea("SalesArea"));

            Series salesSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3
            };
            chartSales.Series.Add(salesSeries);

            // Stock chart
            chartStock.Series.Clear();
            chartStock.ChartAreas.Clear();
            chartStock.ChartAreas.Add(new ChartArea("StockArea"));

            Series stockSeries = new Series("Stock")
            {
                ChartType = SeriesChartType.Column
            };
            chartStock.Series.Add(stockSeries);
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

            var orders = _orderService.GetAllOrders();
            var filteredOrders = _reportService.GetOrdersByDateRange(
                orders, from, to);

            DrawSalesChart(filteredOrders);
            DrawStockChart();
        }

        private void DrawSalesChart(System.Collections.Generic.List<Models.Order> orders)
        {
            var dailySales = _reportService.GetDailySales(orders);

            Series series = chartSales.Series[0];
            series.Points.Clear();

            foreach (var entry in dailySales.OrderBy(d => d.Key))
            {
                series.Points.AddXY(entry.Key.ToShortDateString(), entry.Value);
            }
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
    }
}
