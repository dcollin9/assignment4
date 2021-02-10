using System;
using System.Collections.Generic;

namespace Assignment4.Models
{
    public class TempStorage
    {
        //creates an empty list of EnterRestaurantsModel objects
        private static List<EnterRestaurantsModel> enterRestModel = new List<EnterRestaurantsModel>();

        //makes the list of EnterRestaurantModel objects enumerable
        public static IEnumerable<EnterRestaurantsModel> RestModel => enterRestModel;


        //Uses a list to display user suggestions.
        //Is a method that can be called to add new EnterRestaurantsModel objects into the list
        public static void AddApplication(EnterRestaurantsModel enterRestaurants)
        {
            enterRestModel.Add(enterRestaurants);
        }
    }
}
