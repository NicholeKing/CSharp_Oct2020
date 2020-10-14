using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Controllers
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
            ViewBag.AllShops = _context.Shops.ToList();
            return View();
        }

        [HttpPost("CreateShop")]
        public IActionResult CreateShop(Shop newShop)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newShop);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AllShops = _context.Shops.ToList();
            return View("Index");
        }

        [HttpGet("NewGood")]
        public IActionResult NewGood()
        {
            ViewBag.AllGoods = _context.Goods.ToList();
            return View();
        }

        [HttpPost("CreateGood")]
        public IActionResult CreateGood(Good newGood)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newGood);
                _context.SaveChanges();
                return RedirectToAction("NewGood");
            }
            ViewBag.AllGoods = _context.Goods.ToList();
            return View("NewGood");
        }

        [HttpGet("Shop/{ShopId}")]
        public IActionResult OneShop(int ShopId)
        {
            ViewBag.OneShop = _context.Shops.Include(s => s.GoodsSold).ThenInclude(d => d.Good).FirstOrDefault(a => a.ShopId == ShopId);
            ViewBag.AllGoods = _context.Goods.ToList();
            return View();
        }

        [HttpPost("AddStock")]
        public IActionResult AddStock(Inventory newInv)
        {
            _context.Add(newInv);
            _context.SaveChanges();
            return Redirect($"Shop/{newInv.ShopId}");
        }
    }
}
