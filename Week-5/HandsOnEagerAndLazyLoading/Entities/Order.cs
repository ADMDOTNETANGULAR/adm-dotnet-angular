using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEagerAndLazyLoading.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        [StringLength(5)] //set size as 5
        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}
