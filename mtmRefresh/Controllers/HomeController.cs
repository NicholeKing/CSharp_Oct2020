using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mtmRefresh.Models;
using Microsoft.EntityFrameworkCore;

namespace mtmRefresh.Controllers
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
            ViewBag.AllPlats = _context.Platforms.ToList();
            return View();
        }

        [HttpGet("Games")]
        public IActionResult Games()
        {
            ViewBag.AllGames = _context.Games.ToList();
            return View();
        }

        [HttpPost("AddPlatform")]
        public IActionResult AddPlatform(Platform newPlat)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPlat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("AddGame")]
        public IActionResult AddGame(Game newGame)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newGame);
                _context.SaveChanges();
                return RedirectToAction("Games");
            }
            return View("Games");
        }

        [HttpGet("Platform/{PlatformId}")]
        public IActionResult OnePlat(int PlatformId)
        {
            ViewBag.OnePlat = _context.Platforms.Include(s => s.GamesPlayable).ThenInclude(d => d.Game).FirstOrDefault(a => a.PlatformId == PlatformId);
            ViewBag.AllGames = _context.Games.ToList();
            return View();
        }
        
        [HttpGet("Game/{GameId}")]
        public IActionResult OneGame(int GameId)
        {
            ViewBag.OneGame = _context.Games.Include(s => s.PlatformsPlayableOn).ThenInclude(d => d.Platform).FirstOrDefault(a => a.GameId == GameId);
            ViewBag.AllPlats = _context.Platforms.ToList();
            return View();
        }

        [HttpPost("AddtoPlayable")]
        public IActionResult AddToPlayable(Playable newPlay)
        {
            _context.Add(newPlay);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
