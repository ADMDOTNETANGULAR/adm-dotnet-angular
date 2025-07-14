using HandsOnAPIUsingEFCore.Models;
using HandsOnAPIUsingEFCore.DataContext;
using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIUsingEFCore.Repositories
{
    public class FlightRepository : IFlightContract
    {
        private readonly FlightDBContext _context;
        //public FlightRepository()
        //{
        //    _context = new FlightDBContext(); // This line is incorrect as it does not pass DbContextOptions
        //}
        // Constructor that accepts FlightDBContext as a dependency
        //Initating the context through Dependency Injection
        public FlightRepository(FlightDBContext context)
        {
            _context = context;
        }
        public async Task AddFlightAsync(Flight flight)
        {
          _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFlightAsync(int id)
        {
            var flight = _context.Flights.Find(id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();

        }

        public async Task<Flight> GetFlightByIdAsync(int id)
        {
           return await _context.Flights.FindAsync(id);
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _context.Flights.ToListAsync();
        }

        public Task UpdateFlightAsync(Flight flight)
        {
           _context.Entry(flight).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }
    }
}
