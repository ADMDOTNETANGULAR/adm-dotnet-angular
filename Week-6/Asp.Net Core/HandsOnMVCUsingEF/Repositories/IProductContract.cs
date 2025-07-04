using HandsOnMVCUsingEF.Entities;
namespace HandsOnMVCUsingEF.Repositories
{
    public interface IProductContract
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
    }
}
