using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingViews.Controllers
{
    public class Demo2Controller : Controller
    {
        public IActionResult Index()
        {
            //Navigate to Index to Greet action method
            //set value in TempData
            // TempData is used to pass data between actions
            TempData["name"] = "John Doe";
            //return RedirectToAction("Greet");
            //TempData is used to pass data between actions across different controllers
            return RedirectToAction("Welcome", "Demo1");
        }
        public IActionResult Greet()
        {
            return View();
        }
    }
}
