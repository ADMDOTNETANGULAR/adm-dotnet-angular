using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("Greet")]
        public IActionResult Get()
        {
            return Ok("Hello, World!"); // This returns a simple string response with a 200 OK status
        }
        [Route("GetCities")]
        //default Http method is GET
        public IActionResult GetCities()
        {
            var cities = new List<string>
            {
                "New York",
                "Los Angeles",
                "Chicago",
                "Houston",
                "Phoenix"
            };
            return Ok(cities); // This returns a list of cities in json format  with a 200 OK status
        }
    }
}
