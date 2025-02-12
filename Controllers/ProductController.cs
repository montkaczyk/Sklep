using Microsoft.AspNetCore.Mvc;
using sklep.Models;
using System.Collections.Generic;

namespace sklep.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            List<ProductViewModel> list = new List<ProductViewModel>
            {
                new ProductViewModel { Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 10 },
                new ProductViewModel { Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 20 },
                new ProductViewModel { Name = "Headphones", Category = "Accessories", Price = 150, StockQuantity = 50 }
            };
            return View(list);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ProductViewModel());
        }
    }
}
