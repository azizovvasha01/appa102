using System.Collections.Generic;
using DynamicPropertiesViewModelApp.Models;

namespace DynamicPropertiesViewModelApp.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

        public string FullInfo
        {
            get
            {
                if (Product == null) return "";
                return $"{Product.Name} - Final Price: {Product.DiscountedPrice} AZN";
            }
        }
    }
}
