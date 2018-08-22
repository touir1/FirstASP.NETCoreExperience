using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Display(Name = "Cuisine Type")]
        public CuisineTypes Cuisine { get; set; }

    }
}
