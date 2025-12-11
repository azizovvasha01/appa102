namespace DynamicPropertiesViewModelApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }

        public decimal DiscountedPrice
        {
            get
            {
                return Price - (Price * DiscountPercent / 100);
            }
        }
    }
}
