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
            _productService = new ProductService();
            _orderService = new OrderService(_productService);
            _reportService = new ReportService();
            _exportService = new ExportService();

            ConfigureCharts();
            btnGenerate.Click += btnGenerate_Click;

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
            btnGenerate.Click += btnGenerate_Click;
        }

        private void ConfigureCharts()
        {
            // ---------- SALES CHART ----------
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

            // ---------- STOCK CHART ----------
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
                DataPoint point = new DataPoint
                {
                    XValue = entry.Key.ToOADate(),
                    YValues = new[] { (double)entry.Value }
                };

                series.Points.Add(point);
            }

            AdjustSalesAxisForDataDensity(series.Points.Count);

            chartSales.ChartAreas[0].RecalculateAxesScale();
        }

        private void AdjustSalesAxisForDataDensity(int pointCount)
        {
            ChartArea area = chartSales.ChartAreas[0];

            if (pointCount == 0)
            {
                area.AxisX.Interval = 1;
                return;
            }

            // Target around 10 labels on screen to avoid x-axis clutter.
            int interval = Math.Max(1, (int)Math.Ceiling(pointCount / 10.0));
            area.AxisX.Interval = interval;
            area.AxisX.IntervalType = DateTimeIntervalType.Days;
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

        private void chartStock_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
