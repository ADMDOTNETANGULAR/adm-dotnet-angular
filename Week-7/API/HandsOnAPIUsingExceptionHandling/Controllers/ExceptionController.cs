using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingExceptionHandling.Controllers
{
   
    [ApiController]
    public class ExceptionController : ControllerBase
    {
        [HttpGet("error")]
        public IActionResult ThrowError()
        {
            return Ok("Error Occured, something went wrong, will look forward the issue!!!.");
        }
    }
}
