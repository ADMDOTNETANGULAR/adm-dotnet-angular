using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEagerAndLazyLoading.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }
       
        [Required]
        public string Name { get; set; }
        public double? Price { get; set; }
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public  virtual List<Order> Orders { get; set; }
    }
}
