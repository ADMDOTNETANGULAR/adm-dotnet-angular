using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace HandsOnSessions.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Login()
        {
            var userId="U123";
            //set value in session
            HttpContext.Session.SetString("UserId", userId);
            return RedirectToAction("Index", "Booking");
        }
    }
}
