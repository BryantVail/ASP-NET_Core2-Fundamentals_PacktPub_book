using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson2
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult /*string*/ Index()
        {
            //return View();
            //return "Hello World, I am going to master MVC";
            return Content("Hellow World from Index, returning Content(string msg)");
        }

        public IActionResult IndexUpper()
        {
            return new UpperStringActionResult("Hello World! I'm learning MVC, upper");
        }
    }
    //public class Home2Controller : Controller
    //{
    //    // GET: /<controller>/
    //    //public /*IActionResult*/ string Index()
    //    //{
    //    //    //return View();
    //    //    return "Hello World, I am going to master MVC, Home1";
    //    //}

    //    public IActionResult Index()
    //    {
    //        return Content("Hellow World from Content()");
    //    }
    //}

}
