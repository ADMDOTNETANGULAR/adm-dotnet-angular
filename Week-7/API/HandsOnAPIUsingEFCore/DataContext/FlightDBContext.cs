using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIUsingEFCore.DataContext
{
    public class FlightDBContext:DbContext
    {
        // Constructor to pass options to the base DbContext class
        // This constructor is used to configure the database connection and other options.
        /// <summary>
        /// 
        public FlightDBContext(DbContextOptions<FlightDBContext> options) : base(options)
        {
           
        }
        public DbSet<Models.Flight> Flights { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //seed data
           modelBuilder.Entity<Models.Flight>().HasData(
                new Models.Flight
                {
                    FlightId = 1,
                    FlightName = "Flight 101",
                    FightCode = "FL101",
                    Seats = 150,
                },
                new Models.Flight
                {
                    FlightId = 2,
                    FlightName = "Flight 202",
                    FightCode = "FL202",
                    Seats = 200,
                }
            );
        }
    }
}
