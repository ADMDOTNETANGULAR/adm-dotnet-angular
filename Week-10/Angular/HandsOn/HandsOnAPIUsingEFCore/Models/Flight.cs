using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnAPIUsingEFCore.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        [Required]
        [StringLength(100)]
        public string FlightName { get; set; }
        [Required]
        [StringLength(50)]
        public string FlightCode { get; set; }
        [Required]
       
        public int Seats { get; set; }

    }
}
