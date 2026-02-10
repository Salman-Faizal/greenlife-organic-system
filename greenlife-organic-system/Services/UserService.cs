using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;
using greenlife_organic_system.Data;

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
            bool exists = Customers.Any(c => c.Username == customer.Username);
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
