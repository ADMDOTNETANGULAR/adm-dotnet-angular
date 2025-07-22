using System.ComponentModel.DataAnnotations;
namespace OnlineShopping.ProductService.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
