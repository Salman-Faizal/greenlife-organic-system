using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class AdminDashboardForm : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly NotificationService _notificationService;

        public AdminDashboardForm(
            ProductService productService,
            OrderService orderService)
        {
            InitializeComponent();

            _productService = productService;
            _orderService = orderService;
            _notificationService = new NotificationService();

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblProducts.Text = $"Total Products: {_productService.Products.Count}";

            int activeOrders = _orderService
                .GetAllOrders()
                .Count(o => o.Status != "Delivered");

            lblOrders.Text = $"Active Orders: {activeOrders}";

            int lowStockCount = _notificationService
                .GetLowStockProducts(_productService.Products)
                .Count;

            lblLowStock.Text = $"Low Stock Items: {lowStockCount}";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AdminReportsForm reportsForm =
                new AdminReportsForm(_productService, _orderService);
            reportsForm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Management screen will open here.");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Management screen will open here.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
