using System;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public class ViewProfileForm : Form
    {
        private readonly Customer _customer;
        private readonly UserService _userService;

        private readonly TextBox _txtUsername;
        private readonly TextBox _txtPassword;
        private readonly TextBox _txtFullName;
        private readonly TextBox _txtEmail;
        private readonly TextBox _txtPhone;
        private readonly TextBox _txtAddress;

        public ViewProfileForm(Customer customer, UserService userService)
        {
            _customer = customer;
            _userService = userService;

            Text = "My Profile";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MinimizeBox = false;
            MaximizeBox = false;
            Width = 430;
            Height = 450;

            Label lblUsername = CreateLabel("Username", 20);
            _txtUsername = CreateTextBox(20);

            Label lblPassword = CreateLabel("Password", 75);
            _txtPassword = CreateTextBox(75);
            _txtPassword.UseSystemPasswordChar = true;

            Label lblFullName = CreateLabel("Full Name", 130);
            _txtFullName = CreateTextBox(130);

            Label lblEmail = CreateLabel("Email", 185);
            _txtEmail = CreateTextBox(185);

            Label lblPhone = CreateLabel("Phone", 240);
            _txtPhone = CreateTextBox(240);

            Label lblAddress = CreateLabel("Address", 295);
            _txtAddress = CreateTextBox(295);

            Button btnSave = new Button
            {
                Left = 120,
                Top = 350,
                Width = 80,
                Text = "Save"
            };
            btnSave.Click += BtnSave_Click;

            Button btnCancel = new Button
            {
                Left = 220,
                Top = 350,
                Width = 80,
                Text = "Cancel"
            };
            btnCancel.Click += (_, _) => Close();

            Controls.AddRange(new Control[]
            {
                lblUsername, _txtUsername,
                lblPassword, _txtPassword,
                lblFullName, _txtFullName,
                lblEmail, _txtEmail,
                lblPhone, _txtPhone,
                lblAddress, _txtAddress,
                btnSave, btnCancel
            });

            LoadProfileData();
        }

        private static Label CreateLabel(string text, int top)
        {
            return new Label
            {
                Left = 30,
                Top = top,
                Width = 120,
                Text = text
            };
        }

        private static TextBox CreateTextBox(int top)
        {
            return new TextBox
            {
                Left = 160,
                Top = top,
                Width = 220
            };
        }

        private void LoadProfileData()
        {
            _txtUsername.Text = _customer.Username;
            _txtPassword.Text = _customer.Password;
            _txtFullName.Text = _customer.FullName;
            _txtEmail.Text = _customer.Email;
            _txtPhone.Text = _customer.PhoneNumber;
            _txtAddress.Text = _customer.Address;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Customer updatedCustomer = new Customer
            {
                UserId = _customer.UserId,
                Username = _txtUsername.Text,
                Password = _txtPassword.Text,
                FullName = _txtFullName.Text,
                Email = _txtEmail.Text,
                PhoneNumber = _txtPhone.Text,
                Address = _txtAddress.Text
            };

            bool success = _userService.UpdateCustomerProfile(updatedCustomer, out string errorMessage);
            if (!success)
            {
                MessageBox.Show(errorMessage, "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _customer.Username = updatedCustomer.Username.Trim();
            _customer.Password = updatedCustomer.Password.Trim();
            _customer.FullName = updatedCustomer.FullName.Trim();
            _customer.Email = updatedCustomer.Email.Trim();
            _customer.PhoneNumber = updatedCustomer.PhoneNumber.Trim();
            _customer.Address = updatedCustomer.Address.Trim();

            MessageBox.Show("Profile updated successfully.", "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}