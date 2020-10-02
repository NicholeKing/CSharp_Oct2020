using Microsoft.AspNetCore.Mvc;
namespace newMVC.Controllers
{
    public class HelloController : Controller
    {
        //This is where my routes and controls live
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World from Virginia!";
        }

        [HttpGet]
        [Route("user")]
        public string User()
        {
            return "Hello from the User page!";
        }

        [HttpGet("book")]
        public string Book()
        {
            return "hello from the book page!";
        }

        [HttpGet("{name}")]
        public string Name(string name)
        {
            return $"Hello {name}!";
        }

        [HttpGet("user/{name}")]
        public string username(string name)
        {
            return $"Hello user: {name}";
        }
    }
}