namespace HandsOnAPIUsingEFCore.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; } // Foreign key to User
        public int FlightId { get; set; } // Foreign key to Flight
        public int NumberOfSeats { get; set; } // Number of seats booked
        public string Status { get; set; } = "Pending"; // Booking status (e.g., Pending, Confirmed, Cancelled)
        public User User { get; set; } // Navigation property to User
        public Flight Flight { get; set; } // Navigation property to Flight

    }
}
