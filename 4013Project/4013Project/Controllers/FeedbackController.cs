using Microsoft.AspNetCore.Mvc;

namespace _4013Project.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
