using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            User someUser = new User()
            {
                Name = "Nichole",
                Email = "n@k.com",
                Password = "dhskjhfs",
                hiddenValue = "fhdisl"
            };
            Console.WriteLine(someUser.Name);
            return View();
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            return View();
        }
        [HttpPost("PostMethod")]
        public IActionResult PostMethod(User newUser)
        {
            return View("Success", newUser);
        }
        [HttpGet("redir")]
        public IActionResult redir()
        {
            return View("Success");
        }
    }
}
