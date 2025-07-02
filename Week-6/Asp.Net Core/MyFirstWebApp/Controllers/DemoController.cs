using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        //define the action methods
        public string Welcome()
        {
            return "Welcome to ASP.NET Core MVC!";
        }
        // Action method that takes a parameter
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
        // Action method that takes two parameters and returns their sum
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
