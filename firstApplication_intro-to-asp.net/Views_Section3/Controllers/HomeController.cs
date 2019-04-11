using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Views_Section3.Models;

namespace Views_Section3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var view = View();
            view.ViewData["Layout"] = "~/Views/Shared/_Alternate.cshtml";
            return view;
        }

        public IActionResult Index2()
        {
            //retrieve data & put it in an object
            var employees = new List<Employee>
            {
                new Employee {Id = 10012, Name = "Bryant Vail"},
                new Employee {Id = 10013, Name = "Jason Hall" },
                new Employee {Id = 10015, Name = "Scott Black"}
            };

            ViewBag.Title = "This is index2";

            //send object to the view, through View()
            return View( employees);
        }

        [HttpGet]
        public IActionResult ValidateAge()
        {
            ViewBag.Title = "Validate Age for Voting";
            Person person1 = new Person();
            return View(person1);
        }

        [HttpPost]
        public IActionResult ValidateAge(Person person1)
        {
            //if(person1.Age >= 18)
            //{
            //    //if ViewBag.Message is false, it will not populate
            //    ViewBag.Message = "You Are Eligible to Vote";
            //}
            //else
            //{
            //    //if ViewBag.Message is false, it will not populate
            //    ViewBag.Message = "You Are NOT Eligible to Vote";
            //}

            if (Convert.ToBoolean(Request.Form["OlderThan18"][0]))
            {
                ViewData["OlderThan18"] = true;
                ViewBag.Message = "You are Eligible to Vote!";
            }
            else
            {
                ViewBag.Message = "Sorry, you ARE NOT Old Enough to be eligible to Vote!";
            }

            return View();
        }

        public ActionResult Sample()
        {
            return View();
        }

        public IActionResult Index3()
        {
            ViewBag.Title = "This is Index3";
            Person person = new Person();
            return View(person);
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }

    
}