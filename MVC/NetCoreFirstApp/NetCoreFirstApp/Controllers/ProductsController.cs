using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using NetCoreFirstApp.Models;

namespace NetCoreFirstApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ListofProducts()
        {
            var products = new List<ProductModel>
            {
                new ProductModel{ ProductId=1,  ProductName = "Colgate",ProductDescription = "Toothpaste",price = 120 },
                new ProductModel{ProductId=2 ,ProductName ="Car",ProductDescription = "It is a 4 wheeler car",price=23456 },
                new ProductModel{ ProductId=3,ProductName = "sugar",ProductDescription = "Grocerry",price = 120}

            };
             return View(products);
        }
        [HttpPost]
        public IActionResult ListofProducts(int ProductId)
        {
            var products = new List<ProductModel>
            {
                new ProductModel{  ProductName = "Colgate",ProductDescription = "Toothpaste",price = 120 },
                new ProductModel{ProductName ="Car",ProductDescription = "It is a 4 wheeler car",price=23456 },
                new ProductModel{ ProductName = "sugar",ProductDescription = "Grocerry",price = 120}

            };

            var product = products.Where(product => product.ProductId == ProductId);
            return View(products);
        }
        [HttpPost]
        public IActionResult EditProduct(int ProductId)
        {
            var products = new List<ProductModel>
            {
                new ProductModel{  ProductName = "Colgate",ProductDescription = "Toothpaste",price = 120 },
                new ProductModel{ProductName ="Car",ProductDescription = "It is a 4 wheeler car",price=23456 },
                new ProductModel{ ProductName = "sugar",ProductDescription = "Grocerry",price = 120}

            };

            var product = products.Where(product => product.ProductId == ProductId);
            return View(products);
        }

    }
}
