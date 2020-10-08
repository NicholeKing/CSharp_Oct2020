using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nesdatchi.Models;
using Microsoft.AspNetCore.Http;

namespace nesdatchi.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Fullness", 20);
            HttpContext.Session.SetInt32("Happiness", 20);
            HttpContext.Session.SetInt32("Meals", 3);
            HttpContext.Session.SetInt32("Energy", 50);
            HttpContext.Session.SetString("Reaction", "Start playing with Kirby!");
            return RedirectToAction("Play");
        }

        [HttpGet("Play")]
        public IActionResult Play()
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Reaction = HttpContext.Session.GetString("Reaction");
            return View("Index");
        }

        [HttpGet("Feed")]
        public IActionResult Feed()
        {
            int? meals = HttpContext.Session.GetInt32("Meals");
            if (meals > 0)
            {
                Random rand = new Random();
                meals--;
                HttpContext.Session.SetInt32("Meals", (int)meals);
                int? fullness = HttpContext.Session.GetInt32("Fullness");
                fullness = fullness + rand.Next(5,11);
                HttpContext.Session.SetInt32("Fullness", (int)fullness);
                HttpContext.Session.SetString("Reaction", "Kirby inhaled that meal!");
            }
            return RedirectToAction("Play");
        }

        [HttpGet("Sleep")]
        public IActionResult Sleep()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            if(fullness <= 0 || happiness <= 0)
            {
                HttpContext.Session.SetString("Reaction", "Kirby never woke up");
                return RedirectToAction("Reset");
            } else {
                if(fullness-5 <= 0 || happiness-5 <= 0)
                {
                    HttpContext.Session.SetString("Reaction", "Kirby never woke up");
                    return RedirectToAction("Reset");
                }
                HttpContext.Session.SetInt32("Energy", (int)energy+15);
                HttpContext.Session.SetInt32("Fullness", (int)fullness-5);
                HttpContext.Session.SetInt32("Happiness", (int)happiness-5);
                return RedirectToAction("Play");
            }
        }

        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            ViewBag.Reaction = HttpContext.Session.GetString("Reaction");
            return View();
        }
    }
}
