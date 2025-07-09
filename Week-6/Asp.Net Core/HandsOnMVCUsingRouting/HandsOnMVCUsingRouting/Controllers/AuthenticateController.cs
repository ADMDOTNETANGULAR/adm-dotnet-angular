using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingRouting.Controllers
{
    [Route("auth")]
    public class AuthenticateController : Controller
    {
        //[Route("Create")]
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("LogOut")]
        [HttpPost]
        public IActionResult Logout()
        {
            // Logic for logging out the user
            // For example, clearing session or authentication cookies
           // return RedirectToAction("Index", "Home"); // Redirect to home page after logout
            //redirect to the route
            return Redirect("/auth/Login");
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
