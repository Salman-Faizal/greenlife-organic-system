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

            Save();
            return true;
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

        // Search by product name (partial match)
        public List<Product> SearchByName(string name)
        {
            return Products
                .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                .ToList();
        }

        // Search by category
        public List<Product> SearchByCategory(string category)
        {
            return Products
                .Where(p => p.Category.ToLower() == category.ToLower())
                .ToList();
        }

        // Search by price range
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

        /* ------------------ Persistence ------------------ */

        public void Save()
        {
            JsonDataManager.SaveToFile(ProductFile, Products);
        }
    }
}
