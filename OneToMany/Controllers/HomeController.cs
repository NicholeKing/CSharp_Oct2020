using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context){
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Octopus> AllOctopi = dbContext.Octopi.ToList();
            return View(AllOctopi);
        }

        [HttpGet("octopus/new")]
        public IActionResult NewOctopus()
        {
            return View();
        }

        [HttpPost("octopus/new/submit")]
        public IActionResult SaveOctopus(Octopus oct){
            if(ModelState.IsValid){
                dbContext.Add(oct);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                return View("NewOctopus");
            }
        }

        [HttpGet("octopus/{id}")]
        public IActionResult ShowOctopus(int id){
            Octopus thisOctopus = dbContext.Octopi
                                    .Include(o => o.Tentacles)
                                    .FirstOrDefault(oct => oct.OctopusId == id);
            return View(thisOctopus);
        }

        [HttpGet("tentacle/new")]
        public IActionResult NewTentacle(){
            ViewBag.AllOctopi = dbContext.Octopi.ToList();
            return View();
        }

        [HttpPost("tentacle/new/submit")]
        public IActionResult SaveTentacle(Tentacle tent){
            if(ModelState.IsValid){
                dbContext.Tentacles.Add(tent);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{
                return View("NewTentacle");
            }
        }
    }
}
