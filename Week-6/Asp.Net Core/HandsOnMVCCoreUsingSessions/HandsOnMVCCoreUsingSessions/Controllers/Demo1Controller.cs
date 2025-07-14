using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HandsOnMVCCoreUsingSessions.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index()
        {
           
            ViewBag.Name = HttpContext.Session.GetString("name");
            ViewBag.Age = HttpContext.Session.GetInt32("age");
            ViewBag.PI = HttpContext.Session.GetDouble("pi");
            ViewBag.List = HttpContext.Session.GetComplexData<List<string>>("list");
            return View();
        }
    }
}
