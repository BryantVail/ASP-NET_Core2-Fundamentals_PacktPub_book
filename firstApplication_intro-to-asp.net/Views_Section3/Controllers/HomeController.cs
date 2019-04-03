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
            ViewBag.Title = "This is index2";
            return View();
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
            if(person1.Age >= 18)
            {
                ViewBag.Message = "You Are Eligible to Vote";
            }
            else
            {
                ViewBag.Message = "You Are NOT Eligible to Vote";
            }

            return View();
        }
    }

    
}