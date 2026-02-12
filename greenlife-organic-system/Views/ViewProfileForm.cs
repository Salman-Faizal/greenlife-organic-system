using System;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class ViewProfileForm : Form
    {
        private readonly Customer _customer;
        private readonly UserService _userService;

        public ViewProfileForm(Customer customer, UserService userService)
        {
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));

            InitializeComponent();
            ConfigureForm();
            LoadProfileData();
            WireEvents();
        }

        private void ConfigureForm()
        {
            Text = "My Profile";
            StartPosition = FormStartPosition.CenterScreen;

            txtUsername.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void WireEvents()
        {
            btnUpdate.Click += BtnUpdate_Click;
            btnBack.Click += BtnBack_Click;
        }

        private void LoadProfileData()
        {
            txtUsername.Text = _customer.Username;
            txtPassword.Text = _customer.Password;
            txtConfirmPassword.Text = _customer.Password;
            txtFullName.Text = _customer.FullName;
            txtEmail.Text = _customer.Email;
            txtPhone.Text = _customer.PhoneNumber;
            txtAddress.Text = _customer.Address;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "Password and confirm password do not match.",
                    "Profile Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Customer updatedCustomer = new Customer
            {
                UserId = _customer.UserId,
                Username = _customer.Username,
                Password = txtPassword.Text,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text
            };

            bool success = _userService.UpdateCustomerProfile(updatedCustomer, out string errorMessage);
            if (!success)
            {
                MessageBox.Show(errorMessage, "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _customer.Password = updatedCustomer.Password.Trim();
            _customer.FullName = updatedCustomer.FullName.Trim();
            _customer.Email = updatedCustomer.Email.Trim();
            _customer.PhoneNumber = updatedCustomer.PhoneNumber.Trim();
            _customer.Address = updatedCustomer.Address.Trim();

            MessageBox.Show("Profile updated successfully.", "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}