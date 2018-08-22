using FirstWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.ViewModels
{
    public class RestaurantEditModel
    {

        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineTypes Cuisine { get; set; }
    }
}
