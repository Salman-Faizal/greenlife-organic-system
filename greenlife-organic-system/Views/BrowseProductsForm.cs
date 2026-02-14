using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;


namespace greenlife_organic_system.Views
{
    public partial class BrowseProductsForm : Form
    {
        private bool _isFormReady = false;
        private readonly ProductService _productService;
        private readonly Cart _cart;
        private Product _selectedProduct;
        private readonly OrderService _orderService;
        private readonly Customer _customer;

        public BrowseProductsForm(
            ProductService productService,
            Cart cart,
            Customer customer,
            OrderService orderService)
        {
            InitializeComponent();

            _productService = productService;
            _cart = cart;
            _customer = customer;
            _orderService = orderService;

            picProduct.SizeMode = PictureBoxSizeMode.CenterImage;

            ConfigureGrid();
            ClearProductDetails();

            LoadCategories();
            LoadProducts(_productService.Products);

            // Fully initializaign the form
            _isFormReady = true;
        }

        // ---------------- GRID SETUP ----------------
        private void ConfigureGrid()
        {
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AutoGenerateColumns = true;
        }

        // ---------------- INITIAL RESET ----------------
        private void ClearProductDetails()
        {
            lblName.Text = "";
            lblDescription.Text = "";
            lblPrice.Text = "";
            lblStock.Text = "";
            lblRating.Text = "";

            picProduct.Image?.Dispose();
            picProduct.Image = null;

            flpReviews.Controls.Clear();

            lblReviews.Visible = false;
            numQuantity.Visible = false;
            btnAddToCart.Visible = false;
            lblCartTotal.Visible = false;
        }

        // ---------------- CATEGORY ----------------
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            var categories = _productService.Products
                .Select(p => p.Category)
                .Distinct()
                .ToList();

            foreach (var category in categories)
                cmbCategory.Items.Add(category);

            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // ---------------- FILTERING ----------------
        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string category = cmbCategory.SelectedItem?.ToString() ?? "All";

            var results = _productService.Products.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(searchText))
                results = results.Where(p =>
                    p.Name.ToLower().Contains(searchText));

            if (category != "All")
                results = results.Where(p =>
                    p.Category == category);

            LoadProducts(results.ToList());
            ClearProductDetails();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                ApplyFilters();
        }

        // ---------------- GRID DATA ----------------
        private void LoadProducts(List<Product> products)
        {
            dgvProducts.DataSource = null;

            dgvProducts.DataSource = products.Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Category,
                Price = p.GetDiscountedPrice()
            }).ToList();

            dgvProducts.Columns["ProductId"].Visible = false;
        }

        // ---------------- GRID SELECTION ----------------
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (!_isFormReady)
                return;

            if (dgvProducts.CurrentRow == null)
                return;

            string productId =
                dgvProducts.CurrentRow.Cells["ProductId"].Value.ToString();

            _selectedProduct = _productService.Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (_selectedProduct != null)
                DisplayProductDetails(_selectedProduct);
        }

        // ---------------- PRODUCT DETAILS ----------------
        private void DisplayProductDetails(Product product)
        {
            picProduct.SizeMode = PictureBoxSizeMode.CenterImage;

            lblName.Text = product.Name;
            lblDescription.Text = $"{product.Category}";
            lblPrice.Text = $"{product.GetDiscountedPrice():0.00} LKR";
            lblReviews.Visible = true;
            numQuantity.Visible = true;
            btnAddToCart.Visible = true;
            lblCartTotal.Visible = true;

            // ---------- STOCK & QUANTITY ----------
            numQuantity.Minimum = 0;
            numQuantity.Maximum = product.Stock;

            if (product.Stock > 0)
            {
                numQuantity.Value = 1;
                numQuantity.Enabled = true;
                btnAddToCart.Enabled = true;

                lblStock.Text = $"{product.Stock}";
                lblStock.ForeColor = Color.Black;
            }
            else
            {
                numQuantity.Value = 0;
                numQuantity.Enabled = false;
                btnAddToCart.Enabled = false;

                lblStock.Text = "Out of stock";
                lblStock.ForeColor = Color.Red;
            }

            // ---------- IMAGE ----------
            string imagePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                product.ImagePath ?? string.Empty);

            SetCenteredProductImage(imagePath);

            // ---------- RATING ----------
            lblRating.Text = product.RatingCount == 0
                ? "No ratings yet"
                : $"{product.Rating}/5 ({product.RatingCount} ratings)";

            // ---------- REVIEWS ----------
            LoadReviews(product);
        }

        private void SetCenteredProductImage(string imagePath)
        {
            picProduct.Image?.Dispose();
            picProduct.Image = null;

            if (!File.Exists(imagePath))
                return;

            using FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            using Image originalImage = Image.FromStream(stream);

            Bitmap canvas = new Bitmap(picProduct.Width, picProduct.Height);

            using (Graphics graphics = Graphics.FromImage(canvas))
            {
                graphics.Clear(picProduct.BackColor);

                // overlying large images so they do not fill/stretch the box.
                float scale = Math.Min(
                    1f,
                    Math.Min(
                        (float)canvas.Width / originalImage.Width,
                        (float)canvas.Height / originalImage.Height));

                int drawWidth = (int)(originalImage.Width * scale);
                int drawHeight = (int)(originalImage.Height * scale);

                int x = (canvas.Width - drawWidth) / 2;
                int y = (canvas.Height - drawHeight) / 2;

                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, new Rectangle(x, y, drawWidth, drawHeight));
            }

            picProduct.SizeMode = PictureBoxSizeMode.Normal;
            picProduct.Image = canvas;
        }

        // ---------------- REVIEWS VIEW ----------------
        private void LoadReviews(Product product)
        {
            flpReviews.Controls.Clear();

            if (product.Reviews == null || product.Reviews.Count == 0)
            {
                flpReviews.Controls.Add(new Label
                {
                    Text = "No reviews yet.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Padding = new Padding(5)
                });
                return;
            }

            foreach (var review in product.Reviews)
            {
                Panel panel = new Panel
                {
                    Width = flpReviews.ClientSize.Width - 25,
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(8),
                    Margin = new Padding(5)
                };

                Label header = new Label
                {
                    Text = $"{review.CustomerName} • {review.Date:d} • {review.Rating}/5",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    AutoSize = true
                };

                Label comment = new Label
                {
                    Text = string.IsNullOrWhiteSpace(review.Comment)
                        ? "No written review."
                        : review.Comment,
                    AutoSize = true,
                    MaximumSize = new Size(panel.Width - 10, 0),
                    Top = header.Bottom + 6
                };

                panel.Controls.Add(header);
                panel.Controls.Add(comment);
                flpReviews.Controls.Add(panel);
            }
        }

        // ---------------- CART ----------------
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null || numQuantity.Value == 0)
                return;

            int quantity = (int)numQuantity.Value;
            if (!_productService.ReduceStock(_selectedProduct.ProductId, quantity))
            {
                MessageBox.Show("Unable to add item due to insufficient stock.");
                return;
            }

            _cart.AddItem(_selectedProduct, quantity);
            UpdateCartTotal();
            DisplayProductDetails(_selectedProduct);

            MessageBox.Show("Product added to cart.");
        }

        private void UpdateCartTotal()
        {
            lblCartTotal.Text = $"Cart Total: {_cart.GetTotal():0.00} LKR";
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(_cart, _productService, _customer, _orderService);
            cartForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
