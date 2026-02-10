using greenlife_organic_system.Data;
using greenlife_organic_system.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Linq;

namespace greenlife_organic_system.Services
{
    public class UserService
    {
        private const string AdminFile = @"DataFiles\admins.json";
        private const string CustomerFile = @"DataFiles\customers.json";

        public List<Admin> Admins { get; private set; }
        public List<Customer> Customers { get; set; }

        public UserService()
        {
            Admins = JsonDataManager.LoadFromFile<Admin>(AdminFile);
            Customers = JsonDataManager.LoadFromFile<Customer>(CustomerFile);

            EnsureDefaultAdmin();
        }

        private void EnsureDefaultAdmin()
        {
            if (Admins.Count == 0)
            {
                Admin defaultAdmin = new Admin
                {
                    Username = "admin",
                    Password = "admin123",
                    FullName = "System Administrator",
                    Email = "admin@greenlife.com"
                };

                Admins.Add(defaultAdmin);
                SaveAdmins();
            }
        }

        public User Authenticate(string username, string password)
        {
            Admin admin = Admins
                .FirstOrDefault(a => a.ValidateLogin(username, password));

            if (admin != null)
                return admin;

            Customer customer = Customers
                .FirstOrDefault(c => c.ValidateLogin(username, password));

            return customer;
        }

        public bool RegisterCustomer(Customer customer)
        {
            if (customer == null)
                return false;

            customer.Username = customer.Username?.Trim() ?? string.Empty;
            customer.FullName = customer.FullName?.Trim() ?? string.Empty;
            customer.Email = customer.Email?.Trim() ?? string.Empty;
            customer.PhoneNumber = customer.PhoneNumber?.Trim() ?? string.Empty;
            customer.Address = customer.Address?.Trim() ?? string.Empty;

            bool exists = Customers.Any(c =>
                c.Username.Equals(customer.Username, System.StringComparison.OrdinalIgnoreCase));
            if (exists)
                return false;

            Customers.Add(customer);
            SaveCustomers();
            return true;
        }

        public Customer GetById(string customerId)
        {
            return Customers.FirstOrDefault(c => c.UserId == customerId);
        }

        public bool UpdateCustomerProfile(Customer updatedCustomer, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (updatedCustomer == null)
            {
                errorMessage = "Customer data is required.";
                return false;
            }

            updatedCustomer.Username = updatedCustomer.Username?.Trim() ?? string.Empty;
            updatedCustomer.Password = updatedCustomer.Password?.Trim() ?? string.Empty;
            updatedCustomer.FullName = updatedCustomer.FullName?.Trim() ?? string.Empty;
            updatedCustomer.Email = updatedCustomer.Email?.Trim() ?? string.Empty;
            updatedCustomer.PhoneNumber = updatedCustomer.PhoneNumber?.Trim() ?? string.Empty;
            updatedCustomer.Address = updatedCustomer.Address?.Trim() ?? string.Empty;

            bool hasEmptyRequiredField =
                string.IsNullOrWhiteSpace(updatedCustomer.Username) ||
                string.IsNullOrWhiteSpace(updatedCustomer.Password) ||
                string.IsNullOrWhiteSpace(updatedCustomer.FullName) ||
                string.IsNullOrWhiteSpace(updatedCustomer.Email) ||
                string.IsNullOrWhiteSpace(updatedCustomer.PhoneNumber) ||
                string.IsNullOrWhiteSpace(updatedCustomer.Address);

            if (hasEmptyRequiredField)
            {
                errorMessage = "All profile fields are required.";
                return false;
            }

            Customer existingCustomer = Customers.FirstOrDefault(c => c.UserId == updatedCustomer.UserId);
            if (existingCustomer == null)
            {
                errorMessage = "Customer profile could not be found.";
                return false;
            }

            bool usernameExists = Customers.Any(c =>
                c.UserId != updatedCustomer.UserId &&
                c.Username.Equals(updatedCustomer.Username, System.StringComparison.OrdinalIgnoreCase));

            if (usernameExists)
            {
                errorMessage = "Username is already taken by another account.";
                return false;
            }

            existingCustomer.Username = updatedCustomer.Username;
            existingCustomer.Password = updatedCustomer.Password;
            existingCustomer.FullName = updatedCustomer.FullName;
            existingCustomer.Email = updatedCustomer.Email;
            existingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;
            existingCustomer.Address = updatedCustomer.Address;

            SaveCustomers();
            return true;
        }

        private void SaveAdmins()
        {
            JsonDataManager.SaveToFile(AdminFile, Admins);
        }

        private void SaveCustomers()
        {
            JsonDataManager.SaveToFile(CustomerFile, Customers);
        }

        public void ReloadCustomers()
        {
            Customers = JsonDataManager.LoadFromFile<Customer>(CustomerFile);
        }

    }
}
