using Microsoft.AspNetCore.Mvc;

namespace _4013Project.Controllers
{
    public class ApplyController : Controller
    {
        // GET: /Apply
        [HttpGet]
        public IActionResult Index()
        {
            var model = new _4013Project.Models.Apply();
            return View(model);
        }

        // POST: /Apply
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(_4013Project.Models.Apply model)
        {
            if (!ModelState.IsValid)
            {
                // Return the same view with validation messages
                return View(model);
            }

            // TODO: save to database / send email / whatever your process is

            // Maybe redirect to a confirmation page
            return RedirectToAction("Confirmation");
        }

        // GET: /Apply/Confirmation
        [HttpGet]
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
