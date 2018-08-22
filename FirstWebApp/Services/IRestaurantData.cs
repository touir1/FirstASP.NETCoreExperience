using FirstWebApp.Models;
using System.Collections.Generic;

namespace FirstWebApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
