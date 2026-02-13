using greenlife_organic_system.Models;
using greenlife_organic_system.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greenlife_organic_system.Views
{
    public partial class AdminDashboardForm : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly NotificationService _notificationService;
        private readonly UserService _userService;

        public AdminDashboardForm(
            ProductService productService,
            OrderService orderService,
            UserService userService)
        {
            InitializeComponent();

            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _notificationService = new NotificationService();
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblProducts.Text = $"{_productService.Products.Count} products";

            int activeOrders = _orderService
                .GetAllOrders()
                .Count(o =>
                    !string.Equals(o.Status, "Delivered", StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(o.Status, "Cancelled", StringComparison.OrdinalIgnoreCase));

            lblOrders.Text = activeOrders > 0 ? $"{activeOrders} orders" : "None";

            decimal totalSales = _orderService
                .GetAllOrders()
                .Where(o => o.Status == "Delivered")
                .Sum(o => o.CalculateTotal());

            lblTotSales.Text = $"{totalSales:0.00} LKR";


            int lowStockCount = _notificationService
                .GetLowStockProducts(_productService.Products)
                .Count;

            lblLowStock.Text = lowStockCount > 0 ? $"{lowStockCount} items" : "None";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AdminReportsForm reportsForm =
                new AdminReportsForm(_productService, _orderService, _userService);
            reportsForm.ShowDialog();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            AdminManageProductsForm form =
                new AdminManageProductsForm(_productService);

            form.ShowDialog();
            LoadDashboardData();
        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            AdminManageOrdersForm form =
                new AdminManageOrdersForm(_orderService, _userService);

            form.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AdminManageCustomersForm form =
                new AdminManageCustomersForm(_userService);

            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
