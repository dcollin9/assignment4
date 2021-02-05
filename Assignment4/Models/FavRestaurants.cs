using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class FavRestaurants
    {
        [Required]
        public int Ranks { get; set; }

        [Required]
        public string RestaurantName { get; set; } = "It's all tasty!";

        
        public string FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Website { get; set; }

    }
}
