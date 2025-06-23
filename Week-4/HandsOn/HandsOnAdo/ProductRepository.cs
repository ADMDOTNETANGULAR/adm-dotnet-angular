using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace HandsOnAdo
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
    }
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString="Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ADMDOTNET;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection SqlConnection = null;
        SqlCommand command = null;
        public ProductRepository()
        {
            SqlConnection = new SqlConnection(_connectionString);
            SqlConnection.Open();
        }

        public void Add(Product product)
        {
            try
            {
                string qry = $"Insert into product values({product.Id},'{product.Name}',{product.Price},{product.Stock})";
                command=new SqlCommand(qry, SqlConnection);
                // Execute the command
                command.ExecuteNonQuery();// ExecuteNonQuery is used for commands that do not return any data, like INSERT, UPDATE, DELETE
                SqlConnection.Close(); // Close the connection after executing the command
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    class Test_Product
    {
        static void Main()
        {
            try
            {
                ProductRepository productRepository = new ProductRepository();
                Product product = new Product
                {
                    Id = 2,
                    Name = "Laptop",
                    Price = 50000,
                    Stock = 10
                };
                productRepository.Add(product);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
