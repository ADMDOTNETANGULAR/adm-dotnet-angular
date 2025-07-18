using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnLogging_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogInformation("Log Message in the get method");
                return Ok("Test Success");
            }
            catch (Exception ex)
            {

                _logger.LogError("Log Error: " + ex.Message);
               // return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
               throw new Exception("This is a test exception in the post method");
                
            }
            catch (Exception ex)
            {
                _logger.LogError("Log Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
