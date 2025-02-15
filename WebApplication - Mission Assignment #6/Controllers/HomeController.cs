using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication___Mission_Assignment__6.Models;

namespace WebApplication___Mission_Assignment__6.Controllers
{
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