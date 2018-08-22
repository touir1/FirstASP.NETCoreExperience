using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApp.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "Scott's Pizza place"},
                new Restaurant{Id = 2, Name = "Tersiguels"},
                new Restaurant{Id = 3, Name = "King's Contrivance"}
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
