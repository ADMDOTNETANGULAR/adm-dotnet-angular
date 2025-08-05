using HandsOnAPIUsingEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult AddBooking([FromBody] Booking booking)
        {
            // Here you would typically call a service to handle the booking logic
            // For now, we will just return a success message
            return Ok(new { Message = "Booking added successfully", BookingId = booking.BookingId });
        }
    }
}
