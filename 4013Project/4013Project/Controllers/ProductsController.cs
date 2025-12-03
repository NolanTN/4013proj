using Microsoft.AspNetCore.Mvc;
using _4013Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace _4013Project.Controllers
{
    public class ProductsController : Controller
    {
        // Build 12 dummy products that cycle through your 3 items
        private List<Product> GetDummyProducts()
        {
            var names = new[]
            {
                "OU Varsity Jacket",
                "OU Beanie",
                "OU Wallet"
            };

            var imageUrls = new[]
            {
                "https://cdn.shoplightspeed.com/shops/618583/files/56474534/1600x2048x1/creative-knitwear-childrens-ou-varsity-jacket.jpg",
                "https://images.footballfanatics.com/oklahoma-sooners/mens-jordan-brand-white/crimson-oklahoma-sooners-local-peak-cuffed-knit-hat-with-pom_ss5_p-200884070+pv-1+u-mq8h8dn4l4v9erdntx2k+v-x5svybn3tjo0rcd7c8bt.jpg?_hv=2&w=900",
                "https://tinlizziesokc.com/wp-content/uploads/2024/02/7wltb974ch-scaled.jpg"
            };

            var prices = new[] { 79.99m, 29.99m, 34.99m };

            var products = new List<Product>();

            for (int i = 1; i <= 12; i++)
            {
                int idx = (i - 1) % 3; // 0,1,2,0,1,2...

                products.Add(new Product
                {
                    Id = i,
                    Title = names[idx],
                    ImageUrl = imageUrls[idx],
                    Description = names[idx] + " - sample description for an OU IBC product.",
                    Cost = prices[idx]
                });
            }

            return products;
        }

        public IActionResult Index()
        {
            var products = GetDummyProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var products = GetDummyProducts();
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}



