using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RenderProject.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet("redirect")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Landing");
        }

        [HttpGet("landing")]
        public ViewResult Landing()
        {
            return View("Landing");
        }

        [HttpGet("Second")]
        public IActionResult Second()
        {
            //return View("Index");
            return RedirectToAction("Landing");
        }

        [HttpPost("formmethod")]
        public IActionResult formmethod(string TextField, int NumberField)
        {
            ViewBag.TF = TextField;
            ViewBag.NF = NumberField;
            return View("Result");
        }
    }
}