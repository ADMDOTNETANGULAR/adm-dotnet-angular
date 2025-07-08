using HandsOnMVCUsingEF.DBContext;
using HandsOnMVCUsingEF.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnMVCUsingEF.Repositories
{
    public class ProductRepository : IProductContract
    {
        private readonly OnlineShopContext _context;
        //public ProductRepository()
        //{
        //    _context = new OnlineShopContext();
        //}
        public ProductRepository(OnlineShopContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }
        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
        }
    }
}