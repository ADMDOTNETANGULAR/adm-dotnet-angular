using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace HandsOnMVCCoreUsingSessions.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //Set value in session
            HttpContext.Session.SetString("name", "suren"); //set string value
            HttpContext.Session.SetInt32("age", 12); //set int value
            HttpContext.Session.SetDouble("pi", 3.14); //set double value
            HttpContext.Session.SetComplexData("list", new List<string>() { "Rohan", "Jeson" }); //set complext data in session
            return RedirectToAction("View1");
        }
        public IActionResult View1()
        {
            //Read sessoin value
            ViewBag.Name = HttpContext.Session.GetString("name");
            ViewBag.Age = HttpContext.Session.GetInt32("age");
            ViewBag.PI = HttpContext.Session.GetDouble("pi");
            ViewBag.List = HttpContext.Session.GetComplexData<List<string>>("list");
            return View();
        }
    }
}