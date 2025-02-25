﻿using Microsoft.AspNetCore.Mvc;
using WebApplication___Mission_Assignment__6.Data;
using WebApplication___Mission_Assignment__6.Models;

namespace WebApplication___Mission_Assignment__6.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMovie()
        {
        }
    }
}
