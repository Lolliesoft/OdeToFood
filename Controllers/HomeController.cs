using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.Restaurant {
                Id = 1, Name = "Amir's Pizza Place" 
            };

            //return new ObjectResult(model); //creates a json endpoint

            return View(model); //returns a view result
        }
    }
}
