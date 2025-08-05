using HandsOnAPIUsingEFCore.Models;
namespace HandsOnAPIUsingEFCore.Repositories
{
    public interface IFlightContract
    {
        Task<IEnumerable<Models.Flight>> GetFlightsAsync();
        Task<Flight> GetFlightByIdAsync(int id);
        Task AddFlightAsync(Flight flight);
        Task UpdateFlightAsync(Flight flight);
        Task DeleteFlightAsync(int id);
    }
}
