using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class FavRestaurants
    {
        

        //constructor that sets the rank bc it is read only
        public FavRestaurants(int rank)
        {
            Rank = rank;
        }


        //creating properties of the Top 5 Favorite Restaurants

        //the Rank can only be set in this class, making it a "Read only" after being passed to the controller
        [Required]
        public int Rank { get;  }

        [Required]
        public string RestaurantName { get; set; }

        
        public string FavDish { get; set; }

        [Required]
        public string Address { get; set; }


        //validates phone number format
        [RegularExpression("^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$")]
        public string Phone { get; set; }

        
        public string Website { get; set; }


        public static FavRestaurants[] GetRestaurants()
        {
            //adding the information for each restaurant (creating an instance of each restaurant)
            FavRestaurants fr1 = new FavRestaurants(1)
            {
                
                RestaurantName = "Texas Roadhouse",
                FavDish = "10 oz Ribeye",
                Address = "1265 State St, Orem, UT 84097",
                Phone = "801-111-1111",
                Website = "https://www.texasroadhouse.com/locations/utah/orem"
            };
            FavRestaurants fr2 = new FavRestaurants(2)
            {
                
                RestaurantName = "Bombay House",
                FavDish = "Chicken Tikki Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                Phone = "801-111-1112",
                Website = "https://bombayhouse.com/"
            };
            FavRestaurants fr3 = new FavRestaurants(3)
            {
                
                RestaurantName = "Mi Lindo Guadalajara",
                FavDish = null,
                Address = "446 N Freedom Blvd, Provo, UT 84601",
                Phone = "801-111-1113",
                Website = null
            };
            FavRestaurants fr4 = new FavRestaurants(4)
            {
                
                RestaurantName = "Thai Hut",
                FavDish = "Yellow Curry",
                Address = "410 N University Ave, Provo, UT 84601",
                Phone = "801-111-1114",
                Website = "https://www.thaihut.restaurant/"
            };
            FavRestaurants fr5 = new FavRestaurants(5)
            {
                
                RestaurantName = "Chili's",
                FavDish = "Just Bacon Burger",
                Address = "122 E 1300 S, Orem, UT 84058",
                Phone = "801-111-1115",
                Website = "https://www.chilis.com/"
            };


            //returns an array of FavRestarants objects
            return new FavRestaurants[] { fr1, fr2, fr3, fr4, fr5 };
        }

    }
}
