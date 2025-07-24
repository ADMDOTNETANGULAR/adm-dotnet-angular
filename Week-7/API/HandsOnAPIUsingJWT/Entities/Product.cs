using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingJWT.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = null;
        public int Price { get; set; }
    }
}
