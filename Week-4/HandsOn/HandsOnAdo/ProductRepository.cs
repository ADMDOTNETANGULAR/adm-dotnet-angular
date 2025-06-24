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
        Product? GetById(int id);
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
            try
            {
                command = new SqlCommand($"Delete from Product where Id={id}", SqlConnection);
                command.ExecuteNonQuery(); // Execute the command
                SqlConnection.Close(); // Close the connection after executing the command
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            try
            {
                command=new SqlCommand("Select * from Product",SqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                       Product product=new Product
                        {
                            Id = reader.GetInt32(0), // Assuming Id is the first column
                            Name = reader.GetString(1), // Assuming Name is the second column
                            Price = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2), // Assuming Price is the third column
                            Stock = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3) // Assuming Stock is the fourth column
                        };
                        products.Add(product);
                    }
                    reader.Close(); // Close the reader after reading all data
                    SqlConnection.Close(); // Close the connection after reading data

                }
                return products;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public Product? GetById(int id)
        {
            try
            {
                Product ?product = null;
                command = new SqlCommand($"Select * from Product where Id={id}", SqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                  
                         product = new Product
                        {
                            Id = reader.GetInt32(0), // Assuming Id is the first column
                            Name = reader.GetString(1), // Assuming Name is the second column
                            Price = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2), // Assuming Price is the third column
                            Stock = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3) // Assuming Stock is the fourth column
                        };
                       
                 
                    reader.Close(); // Close the reader after reading all data
                    SqlConnection.Close(); // Close the connection after reading data

                }
                return product;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Product product)
        {
            try
            {
                command = new SqlCommand($"Update Product set Price={product.Price},Stock={product.Stock} where Id={product.Id}", SqlConnection);
                command.ExecuteNonQuery(); // Execute the command
                SqlConnection.Close(); // Close the connection after executing the command
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    class Test_Product
    {
        static void Main()
        {
            try
            {
                do
                {
                    Console.WriteLine("1. Add Product");
                    Console.WriteLine("2. Update Product");
                    Console.WriteLine("3. Delete Product");
                    Console.WriteLine("4. Get Product By Id");
                    Console.WriteLine("5. Get All Products");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    ProductRepository productRepository = new ProductRepository();
                    switch (choice)
                    {
                        case 1:
                            {
                                var product = new Product();
                                Console.Write("Enter Product Id: ");
                                product.Id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Name: ");
                                product.Name = Console.ReadLine();
                                Console.Write("Enter Product Price: ");
                                product.Price = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Stock: ");
                                product.Stock = Convert.ToInt32(Console.ReadLine());
                                productRepository.Add(product);
                                Console.WriteLine("Product added successfully.");
                            }
                            break;
                        case 2:
                            {
                                var product = new Product();
                                Console.Write("Enter Product Id: ");
                                product.Id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Price: ");
                                product.Price = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Product Stock: ");
                                product.Stock = Convert.ToInt32(Console.ReadLine());
                                productRepository.Update(product);
                            }
                            break;
                        case 3:
                            {
                                Console.Write("Enter Product Id: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                productRepository.Delete(id);
                            }
                            break;
                        case 4:
                            {
                                // Get by Id logic here
                                Console.Write("Enter Product Id: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Product? foundProduct = productRepository.GetById(id);
                                if (foundProduct != null)
                                {
                                    Console.WriteLine($"Id: {foundProduct.Id}, Name: {foundProduct.Name}, Price: {foundProduct.Price}, Stock: {foundProduct.Stock}");
                                }
                                else
                                {
                                    Console.WriteLine("Product not found.");
                                }
                            }
                            break;
                        case 5:
                            {
                                foreach (var item in productRepository.GetAll())
                                {
                                    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, Stock: {item.Stock}");
                                }
                            }
                            break;
                        case 6:
                            return; // Exit the loop and program
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                } while (true);
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
