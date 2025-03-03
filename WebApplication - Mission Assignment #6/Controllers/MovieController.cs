using Microsoft.AspNetCore.Mvc;
using WebApplication___Mission_Assignment__6.Data;
using WebApplication___Mission_Assignment__6.Models;
using System.Linq;

namespace WebApplication___Mission_Assignment__6.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Display the form to add a new movie
        public IActionResult AddMovie()
        {
            return View();
        }

        // Save a new movie to the database
        [HttpPost]
        public IActionResult SaveMovie(Movie movie)
        {
            if (ModelState.IsValid) // This checks validation rules
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View("AddMovie", movie); // Reload form with errors if invalid
        }


        // Display a list of all movies
        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        // Display the Edit form for a specific movie
        public IActionResult EditMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // Update an existing movie
        [HttpPost]
        public IActionResult UpdateMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View("EditMovie", movie);
        }

        // Delete a movie
        public IActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("MovieList");
        }
    }
}
