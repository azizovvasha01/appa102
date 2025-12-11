using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DynamicPropertiesViewModelApp.Models;
using DynamicPropertiesViewModelApp.ViewModels;

namespace DynamicPropertiesViewModelApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            var categories = new List<Category>
            {
                new Category{Id = 1, Name = "Electronics"},
                new Category{Id = 2, Name = "Clothes"},
                new Category{Id = 3, Name = "Books"}
            };

            var vm = new ProductViewModel
            {
                Product = new Product(),
                Categories = categories
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var finalPrice = vm.Product.DiscountedPrice;

            TempData["msg"] = $"Product created successfully! Final price = {finalPrice} AZN";

            return RedirectToAction("Create");
        }
    }
}
