using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModels.Models;
using HandsOnMVCUsingModels.Dtos;
namespace HandsOnMVCUsingModels.Controllers
{
    public class DemoController : Controller
    {
        [Route("GetAllBooks")]
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
        public IActionResult ViewOrders()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "C# Programming", Author = "John Doe", Price = 29.99 },
                new Book { Id = 2, Title = "ASP.NET Core", Author = "Jane Smith", Price = 39.99 },
                new Book { Id = 3, Title = "Entity Framework Core", Author = "Mike Johnson", Price = 49.99 }
            };
            var orders= new List<Order>
            {
                new Order { OrderId = "ORD001", OrderDate = DateTime.Now, BookId = 1 },
                new Order { OrderId = "ORD002", OrderDate = DateTime.Now, BookId = 2 }
            };
            // Prepare a list of orders with associated book details
            var bookorders = (from book in books
                             join order in orders on book.Id equals order.BookId
                             select new OrderBook
                             {
                                 Id = book.Id,
                                 Title = book.Title,
                                 Author = book.Author,
                                 Price = book.Price,
                                 OrderId = order.OrderId,
                                 OrderDate = order.OrderDate
                             }).ToList();
            return View(bookorders);
        }
    }
}
