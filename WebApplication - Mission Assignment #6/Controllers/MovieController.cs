using Microsoft.AspNetCore.Mvc;
using WebApplication___Mission_Assignment__6.Data;
using WebApplication___Mission_Assignment__6.Models;
using System.Linq;

namespace WebApplication___Mission_Assignment__6.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor: Inject the database context
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Display the AddMovie form
        public IActionResult AddMovie()
        {
            return View();
        }

        // Handle form submission and save movie to the database
        [HttpPost]
        public IActionResult SaveMovie(Movie movie)
        {
            if (ModelState.IsValid) // Validate the form data
            {
                _context.Movies.Add(movie); // Add movie to database
                _context.SaveChanges(); // Save changes
                return RedirectToAction("MovieList"); // Redirect to the list of movies
            }
            return View("AddMovie"); // If invalid, reload the form
        }

        // Display a list of all movies
        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList(); // Fetch all movies
            return View(movies); // Pass to the view
        }
    }
}

