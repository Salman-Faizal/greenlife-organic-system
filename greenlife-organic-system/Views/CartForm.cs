using System;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;

namespace greenlife_organic_system.Views
{
    public partial class CartForm : Form
    {
        private readonly Cart _cart;

        public CartForm(Cart cart)
        {
            InitializeComponent();
            _cart = cart;

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
            lblTotal.Text = $"Total: {_cart.GetTotal():0.00} LKR";
        }

        // ---------------- INCREASE QTY ----------------
        private void btnIncreaseQty_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            string productId =
                dgvCart.CurrentRow.Cells["ProductId"].Value.ToString();

            OrderItem item = _cart.Items
                .First(i => i.Product.ProductId == productId);

            if (item.Quantity < item.Product.Stock)
            {
                item.Quantity++;
                LoadCart();
            }
            else
            {
                MessageBox.Show("Not enough stock available.");
            }
        }

        // ---------------- DECREASE QTY ----------------
        private void btnDecreaseQty_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            string productId =
                dgvCart.CurrentRow.Cells["ProductId"].Value.ToString();

            OrderItem item = _cart.Items
                .First(i => i.Product.ProductId == productId);

            item.Quantity--;

            if (item.Quantity <= 0)
                _cart.RemoveItem(productId);

            LoadCart();
        }

        // ---------------- REMOVE ITEM ----------------
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            string productId =
                dgvCart.CurrentRow.Cells["ProductId"].Value.ToString();

            _cart.RemoveItem(productId);
            LoadCart();
        }

        // ---------------- CHECKOUT (NEXT STEP) ----------------
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkout will be implemented next.");
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
