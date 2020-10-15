using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GigSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GigSite.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        //Login and register page
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        //Post request for register
        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                } else {
                    //Validate that the user is over 18
                    int year = newUser.DoB.Year;
                    Console.WriteLine($"Today's month: {DateTime.Today.Month}");
                    Console.WriteLine($"New users birth month: {newUser.DoB.Month}");
                    Console.WriteLine($"Today's day: {DateTime.Today.Day}");
                    Console.WriteLine($"New users birth day: {newUser.DoB.Day}");
                    if(DateTime.Today.Year - year < 18)
                    {
                        ModelState.AddModelError("DoB", "User must be over 18!");
                        return View("Index");   
                    } else if(DateTime.Today.Year - year == 18)
                    {
                        if(DateTime.Today.Month - newUser.DoB.Month < 0)
                        {
                            ModelState.AddModelError("DoB", "User must be over 18!");
                            return View("Index");
                        }
                    } else if(DateTime.Today.Month - newUser.DoB.Month == 0)
                    {
                        if(DateTime.Today.Day - newUser.DoB.Day < 0)
                        {
                            ModelState.AddModelError("DoB", "User must be over 18!");
                            return View("Index");
                        }
                    }
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("logged_in", newUser.UserId);
                    return RedirectToAction("Dashboard");
                }
            } else {
                return View("Index");
            }
        }

        //Post request for login
        [HttpPost("Login")]
        public IActionResult Login(LUser login)
        {
            if(ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == login.LEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                } else {
                    var hasher = new PasswordHasher<LUser>();
                    var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LPassword);
                    if(result == 0)
                    {
                        ModelState.AddModelError("LEmail", "Invalid login attempt");
                        return View("Index");
                    }
                    HttpContext.Session.SetInt32("logged_in", userInDb.UserId);
                    return RedirectToAction("Dashboard");
                }
            } else {
                return View("Index");
            }
        }

        //Dashboard page for the logged in user
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            } else {
                ViewBag.LoggedIn = _context.Users.Include(s => s.Commissions).FirstOrDefault(u => u.UserId == (int)loggedin);
                ViewBag.Orders = _context.Orders.Include(d => d.Gig).Where(a => a.UserId == (int)loggedin);
                ViewBag.Commissions = _context.Orders.Include(f => f.Gig).Where(h => h.Gig.UserId == (int)loggedin);
                return View();
            }
        }

        //Add Gig - GET
        [HttpGet("AddGig")]
        public IActionResult AddGig()
        {
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        //Post for adding a gig
        [HttpPost("CreateGig")]
        public IActionResult CreateGig(Gig newGig)
        {
            if(ModelState.IsValid)
            {
                int? loggedin = HttpContext.Session.GetInt32("logged_in");
                newGig.UserId = (int)loggedin;
                _context.Add(newGig);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                return View("AddGig");
            }
        }

        //Edit gig - GET
        [HttpGet("Edit/{GigId}")]
        public IActionResult Edit(int GigId)
        {
            ViewBag.Gig = _context.Gigs.FirstOrDefault(f => f.GigId == GigId);
            return View();
        }
        
        //Post for update
        [HttpPost("UpdateGig/{GigId}")]
        public IActionResult Update(Gig upGig, int GigId)
        {
            if(ModelState.IsValid)
            {
                Gig oldGig = _context.Gigs.FirstOrDefault(g => g.GigId == GigId);
                oldGig.Title = upGig.Title;
                oldGig.Price = upGig.Price;
                oldGig.Description = upGig.Description;
                oldGig.DeliveryTime = upGig.DeliveryTime;
                oldGig.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ViewBag.Gig = _context.Gigs.FirstOrDefault(f => f.GigId == GigId);
            return View("Edit", upGig);
        }

        //View all the gigs - GET
        [HttpGet("AllGigs")]
        public IActionResult AllGigs()
        {
            ViewBag.AllGigs = _context.Gigs.ToList();
            return View();
        }

        //View one gig - GET
        [HttpGet("gig/{GigId}")]
        public IActionResult OneGig(int GigId)
        {
            int? loggedin = HttpContext.Session.GetInt32("logged_in");
            if(loggedin == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.OneGig = _context.Gigs.FirstOrDefault(s => s.GigId == GigId);
            ViewBag.User = loggedin;
            return View();
        }

        //Post for placing an order
        [HttpPost("OrderGig")]
        public IActionResult OrderGig(OrderHistory newOrder)
        {
            if(newOrder.Request == null)
            {
                newOrder.Request = "No special request made";
            }
            _context.Add(newOrder);
            _context.SaveChanges();
            return RedirectToAction("Thanks");
        }
        //View thank you for your order page - GET
        [HttpGet("Thanks")]
        public IActionResult Thanks()
        {
            return View();
        }

        //Delete order - GET
        [HttpGet("Delete/{OrderId}")]
        public IActionResult Delete(int OrderId)
        {
            OrderHistory orderToDelete = _context.Orders.SingleOrDefault(a => a.OrderId == OrderId);
            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        //Logout - GET
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
