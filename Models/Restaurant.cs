using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

        private int _year = 2024;
        public int Year {

            get { return _year; } 
        
            set
            {
                _year = value;
            }
        }
    }
}
