using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("Booking")]
    internal class Booking
    {
        //Scalar Properties
        //Define the properties for the Book entity
        [Key]
        [StringLength(5)]
        [Column(TypeName ="char")]
        public string BookId { get; set; } // Primary Key
        [Column(TypeName ="Date")]
        public DateTime BookingDate { get; set; } // Date of booking
       // [ForeignKey("Movie")]
        public int MovieId { get; set; } // Foreign Key to Movie entity
       //Navigation Property
       // Specifies the foreign key relationship with Movie entity
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; } // Navigation property to Movie entity
        public int UserId { get; set; } // Foreign Key to User entity
        [ForeignKey("UserId")]
        public User User { get; set; } // Navigation property to User entity

    }
}
