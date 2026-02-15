using BrightIdeasSoftware;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace greenlife_organic_system.Views
{
    public partial class MyOrdersForm : Form
    {
        private readonly Customer _customer;
        private readonly OrderService _orderService;
        private readonly ProductService _productService;
        private string _selectedOrderId;

        public MyOrdersForm(
            Customer customer,
            OrderService orderService,
            ProductService productService)
        {
            InitializeComponent();

            _customer = customer;
            _orderService = orderService;
            _productService = productService;

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

            if (dgvOrders.Rows.Count == 0)
            {
                _selectedOrderId = null;
                dgvOrderItems.DataSource = null;
                flpReviewActions.Controls.Clear();
            }

            UpdateCancelOrderButtonState();
        }

        // ---------------- ORDER SELECTION ----------------
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
                return;

            string orderId =
                dgvOrders.CurrentRow.Cells["OrderId"].Value.ToString();

            _selectedOrderId = orderId;

            var order = _orderService
                .GetOrdersByCustomer(_customer.UserId)
                .FirstOrDefault(o => o.OrderId == orderId);

            if (order != null)
            {
                LoadOrderItems(order);
            }

            UpdateCancelOrderButtonState();
        }

        // ---------------- LOAD ORDER ITEMS ----------------
        private void LoadOrderItems(Order order)
        {
            var fields = new[] { "Product", "Price", "Quantity", "Subtotal" };

            DataTable dtInverted = new DataTable();
            dtInverted.Columns.Add("Field Name"); // The labels

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
                    // Assigning the correct value based on the field label
                    row[i + 1] = field switch
                    {
                        "Product" => item.Product?.Name ?? "[Removed Product]",
                        "Price" => item.Product?.GetDiscountedPrice().ToString("0.00") ?? "N/A",
                        "Quantity" => item.Quantity.ToString(),
                        "Subtotal" => item.GetSubtotal().ToString("0.00"),
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

            flpReviewActions.Controls.Clear();

            if (!string.Equals(order.Status, "Delivered", StringComparison.OrdinalIgnoreCase))
                return;

            foreach (var item in order.Items)
            {
                if (item?.Product == null)
                    continue;

                Product matchingProduct = _productService.Products
                    .FirstOrDefault(p => p.ProductId == item.Product.ProductId);

                bool alreadyReviewedForThisOrder = matchingProduct?.Reviews?.Any(r =>
                    r.CustomerId == _customer.UserId
                    && r.OrderId == order.OrderId
                    && r.ProductId == item.Product.ProductId) == true;

                if (item.IsReviewed || alreadyReviewedForThisOrder)
                {
                    item.IsReviewed = true;
                    continue;
                }

                GroupBox grp = new GroupBox
                {
                    Text = $"Review: {item.Product.Name}",
                    Width = flpReviewActions.Width - 25,
                    Height = 140
                };

                NumericUpDown numRating = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 5,
                    Value = 5,
                    Left = 10,
                    Top = 25
                };

                TextBox txtComment = new TextBox
                {
                    Left = 10,
                    Top = 55,
                    Width = grp.Width - 20,
                    Height = 40,
                    Multiline = true,
                    PlaceholderText = "Optional review..."
                };

                Button btnSubmit = new Button
                {
                    Text = "Submit Review",
                    Left = 10,
                    Top = 100
                };

                btnSubmit.Click += (s, e) =>
                {
                    Review review = new Review
                    {
                        CustomerId = _customer.UserId,
                        CustomerName = _customer.FullName,
                        OrderId = order.OrderId,
                        ProductId = item.Product.ProductId,
                        Rating = (int)numRating.Value,
                        Comment = txtComment.Text.Trim(),
                        Date = DateTime.Now
                    };

                    bool success = _productService.AddReview(
                        item.Product.ProductId,
                        review);

                    if (!success)
                    {
                        MessageBox.Show("Unable to submit review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    item.IsReviewed = true;
                    _orderService.SaveOrders();

                    MessageBox.Show("Thank you for your review!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadOrderItems(order); // refresh UI
                };

                grp.Controls.Add(numRating);
                grp.Controls.Add(txtComment);
                grp.Controls.Add(btnSubmit);

                flpReviewActions.Controls.Add(grp);
            }
        }

        private void UpdateCancelOrderButtonState()
        {
            if (dgvOrders.CurrentRow == null)
            {
                btnCancelOrder.Enabled = false;
                return;
            }

            string status = dgvOrders.CurrentRow.Cells["Status"]?.Value?.ToString();
            btnCancelOrder.Enabled = string.Equals(
                status,
                "Pending",
                StringComparison.OrdinalIgnoreCase);
        }

        private void dgvOrderItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Checking if we are in the FIRST COLUMN (Index 0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.CellStyle.Font = new Font(dgvOrderItems.Font, FontStyle.Bold);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedOrderId))
            {
                MessageBox.Show("Please select an order first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Cancel this order? This can only be done while order status is pending.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool cancelled = _orderService.CancelPendingOrder(_selectedOrderId, _customer.UserId);
            if (!cancelled)
            {
                MessageBox.Show("Unable to cancel order. It may have already been shipped.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadOrders();
                return;
            }

            MessageBox.Show("Order cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadOrders();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
