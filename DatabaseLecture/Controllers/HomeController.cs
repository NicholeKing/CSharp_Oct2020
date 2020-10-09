using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatabaseLecture.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLecture.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllUsers = _context.Users.ToList();
            return View();
        }

        [HttpPost("postmethod")]
        public IActionResult postmethod(User newUser)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }
    }
}
