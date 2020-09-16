using OdeToFood.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OdeToFood.Services
{
    public class InMemoryRestaurant : IRestaurantData, IWaiterData
    {
        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Amir's Pizza Place"},
                new Restaurant {Id = 2, Name = "Tersiguels"},
                new Restaurant {Id = 3, Name = "King's Contrivance"}
            };

            _waiters = new List<Waiters>
            {
                new Waiters {Id = 1, waitersName = "Jackie"},
                new Waiters {Id = 2, waitersName = "Abby"}
            };

            

            
        }
        

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        IEnumerable<Waiters> IWaiterData.GetAll()
        {
            return _waiters.OrderBy(w => w.waitersName);
        }

        Waiters IWaiterData.Get(int id)
        {
            return _waiters.FirstOrDefault(w => w.Id == id);
        }

        List<Restaurant> _restaurants;
        List<Waiters> _waiters;
    }
}
