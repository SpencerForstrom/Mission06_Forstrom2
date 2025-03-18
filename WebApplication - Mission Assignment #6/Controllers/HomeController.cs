using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication___Mission_Assignment__6.Models;

namespace WebApplication___Mission_Assignment__6.Controllers
{
    // HomeController.cs
    // This controller handles requests related to the homepage and general content pages.
    // It returns views (Index, About, and AddMovie) for the user page/interface.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult AddMovie()
        {
            return View();
        }
    }
}