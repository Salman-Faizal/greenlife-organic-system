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
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;

        public LoginForm()
        {
            InitializeComponent();

            _productService = new ProductService();
            _orderService = new OrderService(_productService);
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter username and password.";
                return;
            }

            User user = _userService.Authenticate(username, password);

            if (user == null)
            {
                lblMessage.Text = "Invalid login credentials.";
                return;
            }

            this.Hide();

            if (user is Admin)
            {
                AdminDashboardForm adminForm =
                    new AdminDashboardForm(_productService, _orderService);
                adminForm.Show();
            }
            else if (user is Customer customer)
            {
                CustomerDashboardForm customerForm =
                    new CustomerDashboardForm(customer, _productService, _orderService);
                customerForm.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_userService);
            registerForm.ShowDialog();

            _userService.ReloadCustomers();
        }
    }
}

