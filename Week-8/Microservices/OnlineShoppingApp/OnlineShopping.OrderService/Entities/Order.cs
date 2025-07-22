using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.OrderService.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

    }
}
