using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingRouting.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            // Here you would typically retrieve the student details from a database or service
            // For simplicity, we'll just return a view with the student ID
            ViewBag.StudentId = id;
            return View();
        }
        public IActionResult Show(string name)
        {
                       // Here you would typically retrieve the student details based on the name
            // For simplicity, we'll just return a view with the student name
            ViewBag.StudentName = name;
            return View();
        }
    }
}
