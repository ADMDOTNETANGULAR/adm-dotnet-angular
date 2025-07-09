using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingRouting.Controllers
{
    public class DemoController : Controller
    {
        // This action can be accessed via the route demo/Getall
        [Route("MyApp/Getall")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("MyApp/Get")]
        public IActionResult Get()
        {
            // This action can be accessed via the route demo/Get
            return View();
        }
        //access using conventional routing
        public IActionResult GetAll()
        {
            // This action can be accessed via the route demo/Getall
            return View();
        }
        [Route("MyApp/GetById/{id}")]
        public IActionResult GetById(int id)
        {
            // This action can be accessed via the route demo/GetById/{id}
            // You can use the id parameter to retrieve specific data
            ViewBag.Id = id;
            return View();
        }
        //[HttpGet("MyApp/Details/{id}/{name}")]
        //public IActionResult Details(int id,string name)
        //{
        //    // This action can be accessed via the route demo/Details/{id}
        //    // You can use the id parameter to retrieve specific details
        //    ViewBag.Id = id;
        //    ViewBag.Name = name;
        //    return View();
        //}
        [HttpGet("MyApp/Details/{id:int}/{name}")]
        public IActionResult Details(int id, string name)
        {
            // This action can be accessed via the route demo/Details/{id}
            // You can use the id parameter to retrieve specific details
            ViewBag.Id = id;
            ViewBag.Name = name;
            return View();
        }
        [HttpGet("MyApp/GetByAge/{age:int:max(35):min(18)}")]
        public IActionResult GetByAge(int age)
        {
            // This action can be accessed via the route demo/GetByAge/{age}
            // You can use the age parameter to retrieve specific data
            ViewBag.Age = age;
            return View();
        }
    }
}
