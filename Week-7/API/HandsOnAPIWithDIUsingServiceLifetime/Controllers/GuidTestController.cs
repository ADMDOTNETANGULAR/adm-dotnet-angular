using HandsOnAPIWithDIUsingServiceLifetime.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIWithDIUsingServiceLifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidTestController : ControllerBase
    {
        private readonly IGuidService _service1;
        private readonly IGuidService _service2;
        public GuidTestController(IGuidService service1, IGuidService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Service1Guid = _service1.GetGuid(),
                Service2Guid = _service2.GetGuid()
            });
        }
    }
}
