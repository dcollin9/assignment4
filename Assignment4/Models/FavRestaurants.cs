using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class FavRestaurants
    {
        [Required]
        readonly int Rank;

        [Required]
        public string RestaurantName { get; set; }

        
        public string FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        
        public string Website { get; set; }

        public static FavRestaurants[] GetRestaurants()
        {
            //adding the information for each restaurant (creating an instance of each restaurant)
            FavRestaurants fr1 = new FavRestaurants
            {
                Rank = 1,
                RestaurantName = "Texas Roadhouse",
                FavDish = "10 oz Ribeye",
                Address = "1265 State St, Orem, UT 84097",
                Phone = "801-111-1111",
                Website = "https://www.texasroadhouse.com/locations/utah/orem"
            };
            FavRestaurants fr2 = new FavRestaurants
            {
                Rank = 2,
                RestaurantName = "Bombay House",
                FavDish = "Chicken Tikki Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                Phone = "801-111-1112",
                Website = "bombayhouse.com"
            };
            FavRestaurants fr3 = new FavRestaurants
            {
                Rank = 3,
                RestaurantName = "Mi Lindo Guadalajara",
                FavDish = "Carne Asada Tacos",
                Address = "446 N Freedom Blvd, Provo, UT 84601",
                Phone = "801-111-111",
                Website = null
            };
            FavRestaurants fr4 = new FavRestaurants
            {
                Rank = 4,
                RestaurantName = "Thai Hut",
                FavDish = "Yellow Curry",
                Address = "410 N University Ave, Provo, UT 84601",
                Phone = "801-111-111",
                Website = "https://www.thaihut.restaurant/"
            };
            FavRestaurants fr5 = new FavRestaurants
            {
                Rank = 5,
                RestaurantName = "Chili's",
                FavDish = "Just Bacon Burger",
                Address = "122 E 1300 S, Orem, UT 84058",
                Phone = "801-111-111",
                Website = "https://www.chilis.com/"
            };

            return new FavRestaurants[] { fr1, fr2, fr3, fr4, fr5 };
        }

    }
}
