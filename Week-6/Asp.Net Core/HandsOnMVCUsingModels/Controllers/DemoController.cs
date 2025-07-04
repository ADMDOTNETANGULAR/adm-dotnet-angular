using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "C# Programming", Author = "John Doe", Price = 29.99 },
                new Book { Id = 2, Title = "ASP.NET Core", Author = "Jane Smith", Price = 39.99 },
                new Book { Id = 3, Title = "Entity Framework Core", Author = "Mike Johnson", Price = 49.99 }
            };
            return View(books);
        }
        public IActionResult Details()
        {
            //prepare a book model 
            Book book = new Book()
            {
                Id = 1,
                Title = "C# Programming",
                Author = "John Doe",
                Price = 29.99
            };
            return View(book);
        }
    }
}
