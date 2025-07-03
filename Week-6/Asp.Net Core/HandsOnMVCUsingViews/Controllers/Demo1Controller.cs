using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingViews.Controllers
{
    public class Demo1Controller : Controller
    {
       public IActionResult Greet(string name)
        {
            //set name value in ViewData
            ViewData["n"]=name;
            return View();
        }
        public IActionResult GetFlowers()
        {
            //set flowers array in ViewData
            //ViewData is a dictionary object that allows you to pass data from the controller to the view
            ViewData["flowers"] = new string[] { "Rose", "Lilly", "Tulip", "Daisy" };
            return View();
        }
        public IActionResult GetCities()
        {
            //set citites in ViewBag
            //ViewBag is a dynamic object that allows you to pass data from the controller to the view
            ViewBag.User="John Doe";
            ViewBag.Cities= new string[] { "Mumbai", "Delhi", "Bangalore", "Chennai" };
            return View();
        }
        public IActionResult Welcome()
        {
            //returning a view
            return View();
        }


    }
}
    