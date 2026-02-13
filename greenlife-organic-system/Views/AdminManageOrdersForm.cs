using System;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class AdminManageOrdersForm : Form
    {
        private readonly OrderService _orderService;
        private Order _selectedOrder;
        private readonly UserService _userService;

        public AdminManageOrdersForm(
            OrderService orderService,
            UserService userService)
        {
            InitializeComponent();

            _orderService = orderService;
            _userService = userService;

            ConfigureGrids();
            LoadOrders();
            LoadStatuses();
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

        // ---------------- LOAD DATA ----------------
        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders().AsEnumerable();

            if (cbxActiveOrders.Checked)
            {
                orders = orders.Where(o =>
                    string.Equals(o.Status, "Pending", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(o.Status, "Shipped", StringComparison.OrdinalIgnoreCase));
            }

            dgvOrders.DataSource = orders
                .Select(o => new
                {
                    o.OrderId,
                    Customer = GetCustomerPhone(o.CustomerId),
                    o.CustomerId,
                    Date = o.OrderDate,
                    o.Status,
                    Total = o.CalculateTotal()
                }).ToList();

            dgvOrders.Columns["OrderId"].Visible = false;
            dgvOrders.Columns["CustomerId"].Visible = false;
            dgvOrders.Columns["Customer"].HeaderText = "Phone";

            if (dgvOrders.Rows.Count == 0)
            {
                _selectedOrder = null;
                cmbStatus.SelectedItem = null;
                dgvOrderItems.DataSource = null;
            }
        }

        private string GetCustomerPhone(string customerId)
        {
            var customer = _userService.GetById(customerId);
            return customer?.PhoneNumber ?? "Unknown";
        }


        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Shipped");
            cmbStatus.Items.Add("Delivered");
            cmbStatus.Items.Add("Cancelled");
        }

        // ---------------- ORDER SELECTION ----------------
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
                return;

            string orderId =
                dgvOrders.CurrentRow.Cells["OrderId"].Value.ToString();

            _selectedOrder = _orderService
                .GetAllOrders()
                .FirstOrDefault(o => o.OrderId == orderId);

            if (_selectedOrder != null)
            {
                cmbStatus.SelectedItem = _selectedOrder.Status;
                LoadOrderItems(_selectedOrder);
            }
        }

        // ---------------- ORDER ITEMS ----------------
        private void LoadOrderItems(Order order)
        {
            dgvOrderItems.DataSource = order.Items.Select(i => new
            {
                Product = i.Product?.Name ?? "[Removed Product]",
                Price = i.Product?.GetDiscountedPrice(),
                Quantity = i.Quantity,
                Subtotal = i.GetSubtotal()
            }).ToList();
        }

        // ---------------- UPDATE STATUS ----------------
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null || cmbStatus.SelectedItem == null)
                return;

            string newStatus = cmbStatus.SelectedItem.ToString();

            if (_selectedOrder.Status == newStatus)
            {
                MessageBox.Show("Order already has this status.");
                return;
            }

            _orderService.UpdateOrderStatus(
                _selectedOrder.OrderId,
                newStatus
            );

            MessageBox.Show("Order status updated.");
            LoadOrders();
        }

        private void cbxActiveOrders_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void AdminManageOrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
