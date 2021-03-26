using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Razor_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_MVC_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price= 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            return View(array);
        }
    }
}
