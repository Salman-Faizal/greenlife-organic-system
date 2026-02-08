namespace greenlife_organic_system.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetSubtotal()
        {
            return Product.GetDiscountedPrice() * Quantity;
        }
    }
}