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
    public partial class btnBack : Form
    {
        private readonly Customer _customer;
        private readonly UserService _userService;


        public btnBack(Customer customer, UserService userService)
        {
            InitializeComponent();
            _customer = customer;
            _userService = userService;

            LoadProfile();
        }

        private void LoadProfile()
        {
            txtUsername.Text = _customer.Username;
            txtUsername.ReadOnly = true;

            txtFullName.Text = _customer.FullName;
            txtPhone.Text = _customer.PhoneNumber;
            txtEmail.Text = _customer.Email;
            txtAddress.Text = _customer.Address;

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            _customer.FullName = txtFullName.Text.Trim();
            _customer.PhoneNumber = txtPhone.Text.Trim();

            bool success = _userService.UpdateCustomerProfile(_customer);

            if (success)
                MessageBox.Show("Profile updated successfully.");
            else
                MessageBox.Show("Unable to update profile.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
