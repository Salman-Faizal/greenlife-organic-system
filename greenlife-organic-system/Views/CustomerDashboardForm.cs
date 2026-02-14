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
        private readonly UserService _userService;

        public CustomerDashboardForm(
            Customer customer,
            ProductService productService,
            OrderService orderService)
           : this (customer, productService, orderService, new UserService())
        {
        }

        public CustomerDashboardForm(
            Customer customer,
            ProductService productService,
            OrderService orderService,
            UserService userService)
        {
            InitializeComponent();

            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _userService = userService ?? new UserService();  
            _cart = new Cart();

            lblWelcome.Text = $"Welcome, {_customer.FullName}";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseForm = new BrowseProductsForm(
                _productService,
                _cart,
                _customer,
                _orderService);
            browseForm.ShowDialog();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MyOrdersForm ordersForm =
                new MyOrdersForm(_customer, _orderService, _productService);

            ordersForm.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            using ViewProfileForm profileForm = new ViewProfileForm(_customer, _userService);
            profileForm.ShowDialog(this);
            lblWelcome.Text = $"Welcome, {_customer.FullName}";
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
    }
}
