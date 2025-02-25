using Microsoft.AspNetCore.Mvc;

namespace WebApplication___Mission_Assignment__6.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMovie()
        {
            // Handle movie saving logic here (e.g., add to database)
            return RedirectToAction("Index", "Home"); // Redirect after saving
        }
    }
}
