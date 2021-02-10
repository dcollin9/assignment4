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

        [Required]
        public string FavoriteDish { get; set; }

        //validates the phone number format
        [RegularExpression("^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$")]
        public string Phone { get; set; }

    }
}
