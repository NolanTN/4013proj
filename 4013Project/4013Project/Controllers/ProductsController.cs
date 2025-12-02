using Microsoft.AspNetCore.Mvc;
using _4013Project.Models;

namespace _4013Project.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            // Temporary fake data
            var products = new List<Product>();

            for (int i = 1; i <= 12; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Title = "IBC Product One",
                    ImageUrl = "/Content/images/product-placeholder.png",
                    Description = "Image Description",
                    Cost = 19.99m
                });
            }

            return View(products);
        }

        // NEW ACTION
        public ActionResult Details(int id)
        {
            // For now just return a simple demo product.
            // Later you can look this up from a real data source.
            var product = new Product
            {
                Id = id,
                Title = "IBC Product Name",
                Description = "Product Description",
                Cost = 19.99m
            };

            return View(product);
        }
    }
}

