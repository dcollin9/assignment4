using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class EnterRestaurantsModel
    {

        //declaring properties of the EnterRestaurantsModel
        [Required]
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        
        public string FavoriteDish { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}
