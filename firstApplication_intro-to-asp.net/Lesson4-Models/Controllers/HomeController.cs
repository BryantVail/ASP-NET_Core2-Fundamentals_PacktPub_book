using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson4_Models.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson4_Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Product> Products = new List<Product>
            {
                new Product
                {
                    Name = "Mobile Phone",
                    Price = 300,
                },
                new Product {
                    Name  = "Laptop",
                    Price = 1000,
                },
                new Product
                {
                    Name = "Tablet",
                    Price = 600
                }
            };

            Order order = new Order();
            order.Products = Products;
            order.Total = Products.Sum(product => product.Price);
            return View(order);
        }


    }
}   

