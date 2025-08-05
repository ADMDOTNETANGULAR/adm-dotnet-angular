using System.ComponentModel.DataAnnotations;

namespace HandsOnAPIUsingEFCore.DTOS
{
    public class FlightDTO
    {
        public string FlightName { get; set; }
        
        public string FlightCode { get; set; }
      

        public int Seats { get; set; }
    }
}
