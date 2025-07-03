using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingViews.Controllers
{
    public class DemoController : Controller
    {
      
        public string[] GetFlowers()
        {
            return new string[] { "Rose", "Lilly", "Tulip", "Daisy" }; //returning a string array in json format
        }
        public IActionResult Welcome()
        {
            return View("Info"); //returning a view
        }
        public IActionResult Index()
        {
            return View(); //returning a view
        }
    }
}
