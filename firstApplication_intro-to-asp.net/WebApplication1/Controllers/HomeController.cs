using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson2.Models;
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

        public IActionResult index2()
        {
            return View();//View for 'index2' action method
        }

        public IActionResult IndexUpper()
        {
            return new UpperStringActionResult("Hello World! I'm learning MVC, upper");
        }

        [SundayFilter]
        public IActionResult Employee()
        {
            //sample, data usually comes from the database
            Employee emp1 = new Employee
            {
                EmployeeId = 000001,
                Name = "Bryant Vail",
                Designation = "Junior Developer"
                
            };

            ViewBag.Company = "Google Inc";
            ViewData["CompanyLocation"] = "United States";
            return View(emp1);
            
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
