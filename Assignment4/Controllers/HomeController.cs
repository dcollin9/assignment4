using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //home page that displays my Top 5 Favorite Restaurants
        public IActionResult Index()
        {


            //creates a new list of FavRestaurants objects
            List<FavRestaurants> favRests = new List<FavRestaurants>();

            //adds the pre-entered restaurants into the new list
            foreach(FavRestaurants f in FavRestaurants.GetRestaurants())
            {
                favRests.Add(f);

                //replaces null "Favorite Dish" and "Website" values with the appropriate string
                f.FavDish = f.FavDish ?? "It's all tasty!";
                f.Website = f.Website ?? "Coming soon.";
                
            }

            //returns the list of FavRestaurants objects in the favRests list to the Index view
            return View(favRests);
        }


        [HttpGet]
        public IActionResult EnterRestaurants()
        {

            return View();
        }


        [HttpPost]
        public IActionResult EnterRestaurants(EnterRestaurantsModel enterRestaurants)
        {
            //ensures data is valid before putting it into the temporary storage (protection against nulls)
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(enterRestaurants);
                Response.Redirect("DisplayRestaurants");
            }

            return View();
        }

        public IActionResult DisplayRestaurants()
        {
            return View(TempStorage.RestModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
