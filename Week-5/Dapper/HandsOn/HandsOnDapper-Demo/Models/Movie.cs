using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCodeFirst_Demo2.Entities
{
    //Data Model
  
    internal class Movie
    {
        
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime? ReleaseDate { get; set; } 
        public string? Genre { get; set; } 
        public decimal? Rating { get; set; } 
    }
}
