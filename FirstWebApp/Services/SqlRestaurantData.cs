using System.Collections.Generic;
using System.Linq;
using FirstWebApp.Data;
using FirstWebApp.Models;

namespace FirstWebApp.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private FirstWebAppDbContext _context;

        public SqlRestaurantData(FirstWebAppDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();

            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }
    }
}
