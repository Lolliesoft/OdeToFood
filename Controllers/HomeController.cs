using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;
        private IWaiterData _waiterData;
 
      
        public HomeController(IRestaurantData restaurantData, IGreeter greeter, IWaiterData waiterData)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
            _waiterData = waiterData;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            model.Waiters = _waiterData.GetAll();

            //return new ObjectResult(model); //creates a json endpoint

            return View(model); //returns a view result
        }
        public IActionResult Details (int id)
        {
            var model = _restaurantData.Get(id);
            return View(model);
 
        }
    }
}
