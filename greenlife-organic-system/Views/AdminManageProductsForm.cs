using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;

namespace greenlife_organic_system.Views
{
    public partial class AdminManageProductsForm : Form
    {
        private readonly ProductService _productService;
        private Product _selectedProduct;

        public AdminManageProductsForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            ConfigureGrid();
            LoadProducts();
        }

        private void ConfigureGrid()
        {
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AutoGenerateColumns = true;
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _productService.Products
                .Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    p.Category,
                    p.Price,
                    p.Stock,
                    p.Supplier,
                    p.DiscountPercentage
                })
                .ToList();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            string productId = dgvProducts.CurrentRow.Cells["ProductId"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(productId))
                return;

            _selectedProduct = _productService.Products.FirstOrDefault(p => p.ProductId == productId);
            if (_selectedProduct != null)
                PopulateForm(_selectedProduct);
        }

        private void PopulateForm(Product product)
        {
            txtName.Text = product.Name;
            txtCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString("0.00", CultureInfo.InvariantCulture);
            numDiscount.Value = (decimal)product.DiscountPercentage;
            numStock.Value = product.Stock;
            txtSupplier.Text = product.Supplier;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price)
                && !decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return;
            }

            if (price < 100m || price > 10000m)
            {
                MessageBox.Show("Price must be between 100 and 10,000.");
                txtPrice.Focus();
                return;
            }

            Product updated = new Product
            {
                ProductId = _selectedProduct.ProductId,
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Price = price,
                Stock = (int)numStock.Value,
                Supplier = txtSupplier.Text.Trim(),
                DiscountPercentage = (double)numDiscount.Value,
                Rating = _selectedProduct.Rating,
                RatingCount = _selectedProduct.RatingCount,
                ImagePath = _selectedProduct.ImagePath,
                Reviews = _selectedProduct.Reviews
            };

            if (_productService.UpdateProduct(updated))
            {
                MessageBox.Show("Product updated successfully.");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }
    }
}