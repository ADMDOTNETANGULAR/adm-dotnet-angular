using HandsOnAPIUsingModels.Models;
using System.Net.NetworkInformation;

namespace HandsOnAPIUsingModels.Repositories
{
    public interface IProductRepository
    {
        // Define methods for product repository
        void AddProduct(Product product);
        Product GetProductById(Guid id);
        List<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(Guid id);
    }
    public class ProductRepository : IProductRepository
    {
        // Implement the methods defined in the interface
        private static List<Product> _products = new List<Product>()
            {
                new Product { Id = Guid.NewGuid(), Name = "Laptop", Price = 1000.00, Stock = 10 },
            };

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DeleteProduct(Guid id)
        {
            _products.RemoveAll(p => p.Id == id);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(Guid id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            _products.RemoveAll(p => p.Id == product.Id);
            _products.Add(product);
        }
    }
}
