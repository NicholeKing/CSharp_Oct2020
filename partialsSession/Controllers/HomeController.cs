using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using partialsSession.Models;

namespace partialsSession.Controllers
{
    public class HomeController : Controller
    {
        public static AllModels allmodels = new AllModels();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index", allmodels);
        }

        [HttpPost("addDonut")]
        public IActionResult addDonut(Donut newDonut)
        {
            allmodels.AllDonuts.Add(newDonut);
            return RedirectToAction("Index");
        }

        [HttpPost("addDrink")]
        public IActionResult addDrink(Drink newDrink)
        {
            allmodels.AllDrinks.Add(newDrink);
            return RedirectToAction("Index");
        }
    }
}
