using BrightIdeasSoftware;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            var fields = new[] { "Product", "Price", "Quantity", "Subtotal" };

            DataTable dtInverted = new DataTable();
            dtInverted.Columns.Add("Field Name"); // The left-hand labels

            for (int i = 0; i < order.Items.Count; i++)
            {
                dtInverted.Columns.Add("Item " + (i + 1));
            }

            foreach (var field in fields)
            {
                DataRow row = dtInverted.NewRow();
                row[0] = field; // e.g., "Product"

                for (int i = 0; i < order.Items.Count; i++)
                {
                    var item = order.Items[i];
                    // Assign the correct value based on the field label
                    row[i + 1] = field switch
                    {
                        "Product" => item.Product.Name,
                        "Price" => item.Product.GetDiscountedPrice().ToString("C"),
                        "Quantity" => item.Quantity.ToString(),
                        "Subtotal" => item.GetSubtotal().ToString("C"),
                        _ => ""
                    };
                }
                dtInverted.Rows.Add(row);
            }

            // Styling the grid view to look like a key-value pair display
            dgvOrderItems.ColumnHeadersVisible = false;
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.DefaultCellStyle.SelectionBackColor = dgvOrderItems.DefaultCellStyle.BackColor;
            dgvOrderItems.DefaultCellStyle.SelectionForeColor = dgvOrderItems.DefaultCellStyle.ForeColor;
            dgvOrderItems.ClearSelection();


            dgvOrderItems.DataSource = dtInverted;

            //dgvOrderItems.DataSource = order.Items.Select(i => new
            //{
            //    Product = i.Product.Name,
            //    Price = i.Product.GetDiscountedPrice(),
            //    Quantity = i.Quantity,
            //    Subtotal = i.GetSubtotal()
            //}).ToList();

        }

        private void dgvOrderItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if we are in the FIRST COLUMN (Index 0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.CellStyle.Font = new Font(dgvOrderItems.Font, FontStyle.Bold);
            }
        }

        private void lblOrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
