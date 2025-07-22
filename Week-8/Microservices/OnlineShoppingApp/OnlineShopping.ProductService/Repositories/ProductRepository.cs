using OnlineShopping.ProductService.Entities;
using OnlineShopping.ProductService.DBContext;
using Microsoft.EntityFrameworkCore;
namespace OnlineShopping.ProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBDBContext _context;

        public ProductRepository(ProductDBDBContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product=await _context.Products.FindAsync(id);
            _context.Products.Remove(product); 
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
