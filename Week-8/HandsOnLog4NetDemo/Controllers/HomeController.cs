using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnLog4NetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(HomeController));
        [HttpGet("test")]
        public IActionResult Test()
        {
            _logger.Debug("Test endpoint hit");
            _logger.Warn("This is a warning");
            _logger.Error("This is an error log");

            return Ok("Log4net logging from controller!");
        }
        [HttpGet("error")]
        public IActionResult Error()
        {
            try
            {
                throw new Exception("An error occurred in the HomeController");
            }
            catch (Exception ex)
            {

                _logger.Error(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred");
            }
        }
    }
}
