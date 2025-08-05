using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingEFCore.Repositories;
using HandsOnAPIUsingEFCore.Models;
using HandsOnAPIUsingEFCore.DTOS;
namespace HandsOnAPIUsingEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightContract _flightRepository;
        //public FlightController()
        //{
        //    _flightRepository = new FlightRepository(new DataContext.FlightDBContext());
        //}
        // Constructor that accepts IFlightContract as a dependency
        public FlightController(IFlightContract flightRepository)
        {
            _flightRepository = flightRepository;
        }
        //Define the Endpoints
        // GET: api/Flight
        [HttpGet("GetAllFlights")]
        public async Task<IActionResult> GetAllFlights()
        {
            var flights = await _flightRepository.GetFlightsAsync();
            return Ok(flights); // Return 200 OK with the list of flights in JSON format
        }
        // GET: api/Flight/5
        //[HttpGet("GetFlightById")]
        //public async Task<IActionResult> GetFlightById([FromQuery] int id)
        //{
        //    try
        //    {
        //        var flight = await _flightRepository.GetFlightByIdAsync(id);
        //        if (flight == null)
        //        {
        //            return NotFound("Invalid Flight Code"); // Return 404 Not Found if the flight does not exist
        //        }
        //        return Ok(flight); // Return 200 OK with the flight details in JSON format
        //    }
        //    catch (Exception ex)
        //    {
        //        //501 is the status code
        //        return StatusCode(501, ex.Message);//
        //    }
        //}
        [HttpGet("GetFlightById")]
        public async Task<IActionResult> GetFlightById([FromHeader] int id)
        {
            try
            {
                var flight = await _flightRepository.GetFlightByIdAsync(id);
                if (flight == null)
                {
                    return NotFound("Invalid Flight Code"); // Return 404 Not Found if the flight does not exist
                }
                return Ok(flight); // Return 200 OK with the flight details in JSON format
            }
            catch (Exception ex)
            {
                //501 is the status code
                return StatusCode(501, ex.Message);//
            }
        }


        // POST: api/Flight
        [HttpPost("AddFlight")]
        public async Task<IActionResult> AddFlight([FromBody] FlightDTO flight)
        {
            //convert DTO to Model
            var flightModel = new Flight
            {
                FlightName = flight.FlightName,
                FlightCode = flight.FlightCode,
                Seats = flight.Seats
            };
            if (flight == null)
            {
                return BadRequest("Flight data is null"); // Return 400 Bad Request if the flight data is null
            }
            await _flightRepository.AddFlightAsync(flightModel);
            return Ok(flightModel); // Return 200 OK with the added flight details in JSON format
        }
        // PUT: api/Flight/5
        [HttpPut("UpdateFlight")]
        public async Task<IActionResult> UpdateFlight([FromBody] Flight flight)
        {
            if (flight == null)
            {
                return BadRequest("Invalid flight data"); // Return 400 Bad Request if the flight data is invalid
            }
            await _flightRepository.UpdateFlightAsync(flight);
            return Ok(flight); // Return 200 OK with the updated flight details in JSON format
        }
        // DELETE: api/Flight/5
        [HttpDelete("DeleteFlight")]
        public async Task<IActionResult> DeleteFlight([FromQuery] int id)
        {
            await _flightRepository.DeleteFlightAsync(id);
            return NoContent(); // Return 204 No Content to indicate successful deletion
        }
    }
}
