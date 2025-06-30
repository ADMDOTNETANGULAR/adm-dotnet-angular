using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEagerAndLazyLoading.Entities
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
