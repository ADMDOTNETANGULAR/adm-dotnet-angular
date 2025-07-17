using HandsOnAPIUsingDI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IMessageService _messageService;

        // Constructor Injection
        public HelloController(IMessageService messageService)
        {
            _messageService = messageService; //loosely coupled
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_messageService.GetMessage());
        }
    }
}
