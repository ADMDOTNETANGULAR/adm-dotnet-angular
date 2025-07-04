namespace HandsOnMVCUsingEF.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
       public int Quantity { get; set; }
        // Additional properties can be added as needed
        // For example, you might want to include a description or category
    }
}
