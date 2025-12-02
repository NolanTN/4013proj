using _4013Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Apply model)
        {
            if (!ModelState.IsValid)
            {
                // Just return the view with validation errors
                return View(model);
            }

            // Store success text for the popup
            TempData["Success"] = "Your product was submitted for approval. Please allow 5 business days for review.";

            // Redirect so refresh doesn't resubmit the form
            return RedirectToAction("Index");
        }
    }
}