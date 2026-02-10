using System;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class MyOrdersForm : Form
    {
        private readonly Customer _customer;
        private readonly OrderService _orderService;

        public MyOrdersForm(Customer customer, OrderService orderService)
        {
            InitializeComponent();

            _customer = customer;
            _orderService = orderService;

            ConfigureGrids();
            LoadOrders();
        }

        // ---------------- GRID SETUP ----------------
        private void ConfigureGrids()
        {
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;

            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.MultiSelect = false;
        }

        // ---------------- LOAD ORDERS ----------------
        private void LoadOrders()
        {
            var orders = _orderService
                .GetOrdersByCustomer(_customer.UserId);

            dgvOrders.DataSource = orders.Select(o => new
            {
                o.OrderId,
                Date = o.OrderDate,
                o.Status,
                Total = o.CalculateTotal()
            }).ToList();

            dgvOrders.Columns["OrderId"].Visible = false;
        }

        // ---------------- ORDER SELECTION ----------------
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
                return;

            string orderId =
                dgvOrders.CurrentRow.Cells["OrderId"].Value.ToString();

            var order = _orderService
                .GetOrdersByCustomer(_customer.UserId)
                .FirstOrDefault(o => o.OrderId == orderId);

            if (order != null)
                LoadOrderItems(order);
        }

        // ---------------- LOAD ORDER ITEMS ----------------
        private void LoadOrderItems(Order order)
        {
            dgvOrderItems.DataSource = order.Items.Select(i => new
            {
                Product = i.Product.Name,
                Price = i.Product.GetDiscountedPrice(),
                Quantity = i.Quantity,
                Subtotal = i.GetSubtotal()
            }).ToList();
        }
    }
}
