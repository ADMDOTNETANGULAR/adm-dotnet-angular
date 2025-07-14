using Microsoft.AspNetCore.Mvc;

namespace HandsOnSessions.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve the UserId from session
            var userId = HttpContext.Session.GetString("UserId");
            ViewBag.UserId = userId;
            return View();
        }
    }
}
