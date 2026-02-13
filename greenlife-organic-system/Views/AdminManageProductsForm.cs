using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using greenlife_organic_system.Models;
using greenlife_organic_system.Services;
using System.IO;

namespace greenlife_organic_system.Views
{
    public partial class AdminManageProductsForm : Form
    {
        private const int LowStockThreshold = 5;
        private readonly ProductService _productService;
        private Product _selectedProduct;
        private string _pendingImagePath;

        public AdminManageProductsForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            ConfigureGrid();
            LoadProducts();
            ClearFormFields();
        }

        private void ConfigureGrid()
        {
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.RowPrePaint += dgvProducts_RowPrePaint;

            numDiscount.Minimum = 0;
            numDiscount.Maximum = 100;
            numDiscount.DecimalPlaces = 2;

            numStock.Minimum = 0;
            numStock.Maximum = 100000;

            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dgvProducts_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            int stock = Convert.ToInt32(row.Cells["Stock"].Value ?? 0);

            row.DefaultCellStyle.ForeColor = stock <= LowStockThreshold
                ? Color.Red
                : dgvProducts.DefaultCellStyle.ForeColor;
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
                    p.DiscountPercentage,
                    p.Rating
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
            numDiscount.Value = ToBoundedDecimal(product.DiscountPercentage, numDiscount.Minimum, numDiscount.Maximum);
            numStock.Value = ToBoundedDecimal(product.Stock, numStock.Minimum, numStock.Maximum);
            txtSupplier.Text = product.Supplier;
            lblRating.Text = $"{product.Rating}/5 ({product.RatingCount} ratings)";
            _pendingImagePath = product.ImagePath;
            LoadProductImage(product.ImagePath);
        }

        private static decimal ToBoundedDecimal(double value, decimal min, decimal max)
        {

            decimal converted = (decimal)value;
            if (converted < min)
                return min;
            if (converted > max)
                return max;
            return converted;
        }

        private static decimal ToBoundedDecimal(int value, decimal min, decimal max)
        {
            decimal converted = value;
            if (converted < min)
                return min;
            if (converted > max)
                return max;
            return converted;
        }

        private void LoadProductImage(string imagePath)
        {
            picProduct.Image?.Dispose();
            picProduct.Image = null;

            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                return;

            using FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            using Image image = Image.FromStream(stream);
            picProduct.Image = new Bitmap(image);
        }

        private bool ValidateCommonFields(out decimal price)
        {
            price = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtCategory.Text)
                || string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Name, category and supplier are required.");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out price)
                && !decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return false;
            }

            if (price < 100m || price > 10000m)
            {
                MessageBox.Show("Price must be between 100 and 10,000.");
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private string SaveSelectedImage(string sourcePath, string fallbackImagePath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
                return fallbackImagePath ?? string.Empty;

            if (!File.Exists(sourcePath))
                return fallbackImagePath ?? string.Empty;

            string existingRelative = sourcePath.Replace('\\', '/');
            if (existingRelative.StartsWith("Images/", StringComparison.OrdinalIgnoreCase))
                return existingRelative;

            string imagesDirectory = "Images";
            Directory.CreateDirectory(imagesDirectory);

            string extension = Path.GetExtension(sourcePath);
            string fileName = $"product_{DateTime.Now:yyyyMMddHHmmssfff}{extension}";
            string destinationPath = Path.Combine(imagesDirectory, fileName);

            File.Copy(sourcePath, destinationPath, true);
            return destinationPath.Replace('\\', '/');
        }

        private Product BuildProduct(Product baseProduct, decimal price)
        {
            return new Product
            {
                ProductId = baseProduct.ProductId,
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Price = price,
                Stock = (int)numStock.Value,
                Supplier = txtSupplier.Text.Trim(),
                DiscountPercentage = (double)numDiscount.Value,
                Rating = baseProduct.Rating,
                RatingCount = baseProduct.RatingCount,
                ImagePath = SaveSelectedImage(_pendingImagePath, baseProduct.ImagePath),
                Reviews = baseProduct.Reviews ?? new List<Review>()
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateCommonFields(out decimal price))
                return;

            Product created = BuildProduct(new Product
            {
                ProductId = _productService.GenerateNextProductId(),
                Rating = 0,
                RatingCount = 0,
                Reviews = new List<Review>(),
                ImagePath = string.Empty
            }, price);

            _productService.AddProduct(created);
            MessageBox.Show("Product added successfully.");
            LoadProducts();
            ClearFormFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (!ValidateCommonFields(out decimal price))
                return;

            Product updated = BuildProduct(_selectedProduct, price);

            if (_productService.UpdateProduct(updated))
            {
                MessageBox.Show("Product updated successfully.");
                LoadProducts();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete '{_selectedProduct.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes)
                return;

            if (_productService.DeleteProduct(_selectedProduct.ProductId))
            {
                MessageBox.Show("Product deleted successfully.");
                LoadProducts();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select Product Image"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            _pendingImagePath = dialog.FileName;
            LoadProductImage(_pendingImagePath);
        }

        private void ClearFormFields()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtSupplier.Clear();
            numDiscount.Value = 0;
            numStock.Value = 0;
            lblRating.Text = "Rating: -";
            _pendingImagePath = string.Empty;
            _selectedProduct = null;

            picProduct.Image?.Dispose();
            picProduct.Image = null;

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
        }

        private void AdminManageProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}