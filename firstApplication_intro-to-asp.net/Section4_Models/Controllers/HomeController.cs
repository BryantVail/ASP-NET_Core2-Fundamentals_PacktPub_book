using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Section4_Models.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Section4_Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            /*
             * Build the products model. It is NOT RECOMMENDED to build models in Controller Action Methods like this. 
             *  in real world application, these models and the respective Data Access Layer (DAL) would be in separate projects.
             *  we care creating it here to make things simpler to explain
             */

            List<Product> Products = new List<Product>
            {
                new Product
                {
                    Name = "Mobile Phone",
                    Price = 300
                },
                new Product
                {
                    Name = "Laptop",
                    Price= 1000
                },
                new Product
                {
                    Name = "Tablet",
                    Price= 600
                }
            };//end object creation

            Order order = new Order();
            order.Products = Products;
            order.Total = Products.Sum(product => product.Price);

            return View(order);
        }
    }
}
