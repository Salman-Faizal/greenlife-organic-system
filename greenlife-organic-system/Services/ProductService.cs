using System.Collections.Generic;
using System.Linq;
using greenlife_organic_system.Models;
using greenlife_organic_system.Data;

namespace greenlife_organic_system.Services
{
    public class ProductService
    {
        private const string ProductFile = @"DataFiles\products.json";

        public List<Product> Products { get; private set; }

        public ProductService()
        {
            Products = JsonDataManager.LoadFromFile<Product>(ProductFile);
        }

        /* ------------------ Admin Operations ------------------ */

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Save();
        }

        public bool UpdateProduct(Product updatedProduct)
        {
            Product existing = Products
                .FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (existing == null)
                return false;

            existing.Name = updatedProduct.Name;
            existing.Category = updatedProduct.Category;
            existing.Price = updatedProduct.Price;
            existing.Stock = updatedProduct.Stock;
            existing.Supplier = updatedProduct.Supplier;
            existing.DiscountPercentage = updatedProduct.DiscountPercentage;
            existing.ImagePath = updatedProduct.ImagePath;
            existing.Reviews = updatedProduct.Reviews;
            existing.Rating = updatedProduct.Rating;
            existing.RatingCount = updatedProduct.RatingCount;

            Save();
            return true;
        }

        public string GenerateNextProductId()
        {
            int maxId = Products
                .Select(p => p?.ProductId)
                .Where(id => !string.IsNullOrWhiteSpace(id)
                    && id.StartsWith("P", System.StringComparison.OrdinalIgnoreCase)
                    && int.TryParse(id.Substring(1), out _))
                .Select(id => int.Parse(id.Substring(1)))
                .DefaultIfEmpty(0)
                .Max();

            return $"P{(maxId + 1):D3}";
        }


        public bool DeleteProduct(string productId)
        {
            Product product = Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
                return false;

            Products.Remove(product);
            Save();
            return true;
        }

        /* ------------------ Search Operations ------------------ */

        // Search by product name
        public List<Product> SearchByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Products.ToList();

            string normalized = name.Trim();
            return Products
                .Where(p => !string.IsNullOrWhiteSpace(p.Name)
                    && p.Name.Contains(normalized, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Search by category
        public List<Product> SearchByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return Products.ToList();

            string normalized = category.Trim();

            return Products
                .Where(p => !string.IsNullOrWhiteSpace(p.Category)
                    && p.Category.Equals(normalized, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Search by price range (not yet implemented)
        public List<Product> SearchByPrice(decimal minPrice, decimal maxPrice)
        {
            return Products
                .Where(p => p.GetDiscountedPrice() >= minPrice
                         && p.GetDiscountedPrice() <= maxPrice)
                .ToList();
        }

        /* ------------------ Stock Handling ------------------ */

        public bool ReduceStock(string productId, int quantity)
        {
            Product product = Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product == null || product.Stock < quantity)
                return false;

            product.Stock -= quantity;
            Save();
            return true;
        }

        public bool IncreaseStock(string productId, int quantity)
        {
            Product product = Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product == null || quantity <= 0)
                return false;

            product.Stock += quantity;
            Save();
            return true;
        }

        /* ------------------ Add Review functionality ------------------ */

        public bool AddReview(string productId, Review review)
        {
            if (review == null
                || string.IsNullOrWhiteSpace(review.CustomerId)
                || string.IsNullOrWhiteSpace(review.OrderId)
                || review.Rating < 1
                || review.Rating > 5)
            {
                return false;
            }

            Product product = Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
                return false;

            product.Reviews ??= new List<Review>();

            bool alreadyReviewed = product.Reviews.Any(r =>
                r.CustomerId == review.CustomerId
                && r.OrderId == review.OrderId
                && r.ProductId == productId);

            if (alreadyReviewed)
                return false;

            review.ProductId = productId;
            product.Reviews.Add(review);

            var validRatings = product.Reviews
                .Where(r => r.Rating >= 1 && r.Rating <= 5)
                .Select(r => r.Rating)
                .ToList();

            product.RatingCount = validRatings.Count;
            product.Rating = product.RatingCount == 0
                ? 0
                : (int)System.Math.Round(validRatings.Average());

            Save();
            return true;
        }

        /* ------------------ database deploy ------------------ */
        public void Save()
        {
            JsonDataManager.SaveToFile(ProductFile, Products);
        }
    }
}
