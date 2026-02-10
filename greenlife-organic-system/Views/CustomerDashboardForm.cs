using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly Customer _customer;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly Cart _cart;

        public CustomerDashboardForm(
            Customer customer,
            ProductService productService,
            OrderService orderService)
        {
            InitializeComponent();

            _customer = customer;
            _productService = productService;
            _orderService = orderService;
            _cart = new Cart();

            lblWelcome.Text = $"Welcome, {_customer.FullName}";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseForm = new BrowseProductsForm(_productService, _cart);
            browseForm.ShowDialog();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer order history screen will open here.");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer profile screen will open here.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(_cart, _productService, _customer, _orderService);
            cartForm.ShowDialog();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
