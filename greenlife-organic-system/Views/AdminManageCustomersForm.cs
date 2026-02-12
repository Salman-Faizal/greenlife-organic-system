using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class AdminManageCustomersForm : Form
    {
        private readonly UserService _userService;
        private readonly BindingList<CustomerGridRow> _customerRows;

        private Customer _selectedCustomer;
        private bool _isEditMode;

        public AdminManageCustomersForm(UserService userService)
        {
            InitializeComponent();

            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _customerRows = new BindingList<CustomerGridRow>();
        }

        private void AdminManageCustomersForm_Load(object sender, EventArgs e)
        {
            ConfigureCustomerGrid();
            SetEditMode(false);
            LoadCustomers();
        }

        private void ConfigureCustomerGrid()
        {
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = _customerRows;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;

            dgvCustomers.Columns[nameof(CustomerGridRow.UserId)].Visible = false;
            dgvCustomers.Columns[nameof(CustomerGridRow.Username)].HeaderText = "Username";
            dgvCustomers.Columns[nameof(CustomerGridRow.FullName)].HeaderText = "Full Name";
            dgvCustomers.Columns[nameof(CustomerGridRow.Email)].HeaderText = "Email";
            dgvCustomers.Columns[nameof(CustomerGridRow.PhoneNumber)].HeaderText = "Phone Number";
        }

        private void LoadCustomers(string selectedCustomerId = null)
        {
            _userService.ReloadCustomers();

            _customerRows.Clear();
            foreach (Customer customer in _userService.Customers)
            {
                _customerRows.Add(new CustomerGridRow
                {
                    UserId = customer.UserId,
                    Username = customer.Username,
                    FullName = customer.FullName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber
                });
            }

            if (_customerRows.Count == 0)
            {
                _selectedCustomer = null;
                ClearDetails();
                btnEditCustomer.Enabled = false;
                return;
            }

            btnEditCustomer.Enabled = true;

            int rowIndex = 0;
            if (!string.IsNullOrWhiteSpace(selectedCustomerId))
            {
                int foundIndex = _customerRows.ToList()
                    .FindIndex(c => c.UserId == selectedCustomerId);

                rowIndex = foundIndex >= 0 ? foundIndex : 0;
            }

            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[rowIndex].Selected = true;
            dgvCustomers.CurrentCell = dgvCustomers.Rows[rowIndex].Cells[nameof(CustomerGridRow.Username)];
            LoadSelectedCustomerToDetails();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                return;
            }

            LoadSelectedCustomerToDetails();
        }

        private void LoadSelectedCustomerToDetails()
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                _selectedCustomer = null;
                ClearDetails();
                return;
            }

            CustomerGridRow selectedRow = dgvCustomers.SelectedRows[0].DataBoundItem as CustomerGridRow;
            if (selectedRow == null)
            {
                _selectedCustomer = null;
                ClearDetails();
                return;
            }

            Customer customer = _userService.GetById(selectedRow.UserId);
            if (customer == null)
            {
                _selectedCustomer = null;
                ClearDetails();
                return;
            }

            _selectedCustomer = customer;
            txtUsername.Text = customer.Username;
            txtFullName.Text = customer.FullName;
            txtEmail.Text = customer.Email;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtAddress.Text = customer.Address;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first.", "Manage Customers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_isEditMode)
            {
                SetEditMode(true);
                return;
            }

            if (!ValidateCustomerInputs(out string validationError))
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer updatedCustomer = new Customer
            {
                UserId = _selectedCustomer.UserId,
                Username = txtUsername.Text.Trim(),
                Password = _selectedCustomer.Password,
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            bool updated = _userService.UpdateCustomerProfile(updatedCustomer, out string errorMessage);
            if (!updated)
            {
                MessageBox.Show(errorMessage, "Manage Customers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Customer details updated successfully.", "Manage Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetEditMode(false);
            LoadCustomers(updatedCustomer.UserId);
        }

        private bool ValidateCustomerInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorMessage = "All fields are required.";
                return false;
            }

            string email = txtEmail.Text.Trim();
            bool emailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailValid)
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }

            string phone = txtPhoneNumber.Text.Trim();
            bool phoneValid = phone.All(ch => char.IsDigit(ch) || ch == '+' || ch == '-' || ch == ' ' || ch == '(' || ch == ')');
            if (!phoneValid)
            {
                errorMessage = "Phone number can contain digits and common phone symbols only.";
                return false;
            }

            return true;
        }

        private void SetEditMode(bool isEditMode)
        {
            _isEditMode = isEditMode;

            txtUsername.ReadOnly = !isEditMode;
            txtFullName.ReadOnly = !isEditMode;
            txtEmail.ReadOnly = !isEditMode;
            txtPhoneNumber.ReadOnly = !isEditMode;
            txtAddress.ReadOnly = !isEditMode;
            dgvCustomers.Enabled = !isEditMode;

            btnEditCustomer.Text = isEditMode ? "Save Changes" : "Edit Customer";
        }

        private void ClearDetails()
        {
            txtUsername.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class CustomerGridRow
        {
            public string UserId { get; set; }
            public string Username { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}