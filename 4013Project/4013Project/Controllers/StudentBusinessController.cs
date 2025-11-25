using _4013Project.Models;
using Microsoft.AspNetCore.Mvc;


namespace _4013Project.Controllers
{
    public class StudentBusinessController : Controller
    {
        public ActionResult Index()
        {
            var cards = new List<StudentBusinessCard>
            {
                new StudentBusinessCard { Id = 1, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1504754524776-8f4f37790ca0\r\n" },
                new StudentBusinessCard { Id = 2, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1504754524776-8f4f37790ca0\r\n" },
                new StudentBusinessCard { Id = 3, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1521737604893-d14cc237f11d\r\n" },
                new StudentBusinessCard { Id = 4, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1498654896293-37aacf113fd9\r\n" },
                new StudentBusinessCard { Id = 5, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1504754524776-8f4f37790ca0\r\n" },
                new StudentBusinessCard { Id = 6, Name = "Student Business", ImageUrl = "https://images.unsplash.com/photo-1521791136064-7986c2920216\r\n" }
            };

            return View(cards);
        }

        public ActionResult Details(int id)
        {
            // Fake example — normally load from DB
            var business = new StudentBusinessCard
            {
                Id = id,
                Name = "Student Business " + id,
                ImageUrl = "/Content/images/business" + id + ".jpg"
            };

            return View(business);
        }
    }
}

