using System;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class CartForm : Form
    {
        private readonly Cart _cart;
        private readonly ProductService _productService;
        private readonly Customer _customer;
        private readonly OrderService _orderService;

        public CartForm(Cart cart, ProductService productService, Customer customer, OrderService orderService)
        {
            InitializeComponent();
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));

            ConfigureGrid();
            LoadCart();
        }

        // ---------------- GRID SETUP ----------------
        private void ConfigureGrid()
        {
            dgvCart.ReadOnly = true;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.MultiSelect = false;
            dgvCart.AutoGenerateColumns = true;
        }

        // ---------------- LOAD CART ----------------
        private void LoadCart()
        {
            dgvCart.DataSource = null;

            dgvCart.DataSource = _cart.Items.Select(i => new
            {
                ProductId = i.Product.ProductId,
                Product = i.Product.Name,
                Price = i.Product.GetDiscountedPrice(),
                Quantity = i.Quantity,
                Subtotal = i.GetSubtotal()
            }).ToList();

            dgvCart.Columns["ProductId"].Visible = false;
            UpdateTotal();
        }

        // ---------------- TOTAL ----------------
        private void UpdateTotal()
        {
            lblTotal.Text = $"Total Amount: {_cart.GetTotal():0.00} LKR";
        }

        private bool TryGetSelectedCartItem(out OrderItem item)
        {
            item = null;

            DataGridViewRow selectedRow = dgvCart.SelectedRows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => !r.IsNewRow);

            if (selectedRow == null && dgvCart.CurrentCell != null)
                selectedRow = dgvCart.Rows[dgvCart.CurrentCell.RowIndex];

            if (selectedRow == null)
                return false;

            object value = selectedRow.Cells["ProductId"].Value;
            string productId = value?.ToString();

            if (string.IsNullOrWhiteSpace(productId))
                return false;

            item = _cart.Items.FirstOrDefault(i => i.Product.ProductId == productId);
            return item != null;
        }

        // ---------------- INCREASE QTY ----------------
        private void btnIncreaseQty_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCartItem(out OrderItem item))
                return;

            if (!_productService.ReduceStock(item.Product.ProductId, 1))
            {
                MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            item.Quantity++;
            LoadCart();
        }

        // ---------------- DECREASE QTY ----------------
        private void btnDecreaseQty_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCartItem(out OrderItem item))
                return;

            item.Quantity--;
            _productService.IncreaseStock(item.Product.ProductId, 1);

            if (item.Quantity <= 0)
                _cart.RemoveItem(item.Product.ProductId);

            LoadCart();
        }

        // ---------------- REMOVE ITEM ----------------
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCartItem(out OrderItem item))
                return;

            _productService.IncreaseStock(item.Product.ProductId, item.Quantity);
            _cart.RemoveItem(item.Product.ProductId);
            LoadCart();
        }

        // ---------------- CHECKOUT ----------------
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Confirm checkout?\n\nYour total is {_cart.GetTotal():0.00} LKR\nPayment will be collected upon delivery.",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            bool success = _orderService.PlaceOrder(_customer, _cart);

            if (!success)
            {
                MessageBox.Show(
                    "Order could not be placed due to insufficient stock.",
                    "Checkout Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            LoadCart(); // cart is now empty
            MessageBox.Show(
                "Order placed successfully!\n\nYour order is now pending.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
