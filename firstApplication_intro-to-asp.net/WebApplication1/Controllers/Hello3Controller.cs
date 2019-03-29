using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson2
{
    public class Hello3Controller : Controller
    {
        // GET: /<controller>/

        public ActionResult Welcome(int id)
        {
            /*example: 
             *
             *  http://localhost/Hello3/Welcome/1
             */
            return View();
        }

        //ActionResult Welcome()
        public ActionResult Welcome()
        {
            return View();
        }

        //ActionResult Greeting
        public ActionResult Greeting(int id)
        {
            return View();
        }
    }
}
