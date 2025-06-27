using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    //Data Model
    [Table("tbl_movies")]
    internal class Movie
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Auto-increment is not used
        public int MovieId { get; set; }
        [Required] // Title is mandatory, cannot be null applied not null constraint
        [StringLength(50)] // Title can have a maximum length of 50 characters
        [Column("title",TypeName ="varchar")] // Maps to the column "movie_title" in the database
        public string Title { get; set; }
        [Required] // Director is mandatory, cannot be null
        [StringLength(50)] // Director can have a maximum length of 50 characters
        [Column(TypeName = "varchar")] // Maps to the column "director" in the database
        public string Director { get; set; }

        [Column(TypeName ="Date")]
        public DateTime? ReleaseDate { get; set; } // Nullable DateTime type for release date, can be null
        [Column(TypeName = "varchar")]
        [StringLength(20)] // Genre can have a maximum length of 30 characters
        public string? Genre { get; set; } // Nullable string type for genre, can be null
        public decimal? Rating { get; set; } // Nullable decimal type for rating, can be null
    }
}
