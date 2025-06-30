using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using HandsOnDapper_Demo.Models;
namespace HandsOnDapper_Demo
{
    internal class Program
    {
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ADMDOTNET;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        IDbConnection db;
        public Program()
        {
            db = new SqlConnection(connectionString);
        }
        
        private void GetById(int id)
        {

            try
            {
                db.Open();// Open the connection
                          //Fetching a record from the Product table by Id
                var sql = "SELECT * FROM Product WHERE Id = @Id";
               // var product = db.QuerySingle<Product>($"SELECT * FROM Product where Id={id}");
                var product = db.QuerySingleOrDefault<Product>(sql, new { Id = id });
                if (product == null)
                {
                    Console.WriteLine($"No product found with Id: {id}");

                }
                else
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }



        }

        private void GetAll()
        {

            try
            {
                db.Open();// Open the connection
                          //Fetching all records from the Product table
                var products = db.Query<Product>("SELECT * FROM Product").ToList();
                // Displaying the records
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                Console.WriteLine();
                //Using QueryFirst to get the first record
                var firstProduct = db.QueryFirst<Product>("SELECT * FROM Product");
                Console.WriteLine($"First Product - Id: {firstProduct.Id}, Name: {firstProduct.Name}, Price: {firstProduct.Price}, Stock: {firstProduct.Stock}");
                //Using QueryMultiple to get multiple records
                var sql = "SELECT * FROM Product; SELECT COUNT(*) FROM Product";
                Console.WriteLine(sql);
                using (var multi = db.QueryMultiple(sql))
                {
                    var allProducts = multi.Read<Product>().ToList();
                    var count = multi.ReadSingle<int>();
                    Console.WriteLine($"Total Products: {count}");
                    foreach (var product in allProducts)
                    {
                        Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                    }
                }
                //Query sepecific columns
                var specificColumns = db.Query("SELECT Name, Price FROM Product").ToList();
                Console.WriteLine("Specific Columns (Name, Price):");
                foreach (var item in specificColumns)
                {
                    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
                }
                //Execute Reader to read data
                using (var reader = db.ExecuteReader("SELECT * FROM Product"))
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Price: {reader["Price"]}, Stock: {reader["Stock"]}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close(); // Ensure the connection is closed in case of an exception
            }

        }
        private void AddProduct(Product product)
        {
            try
            {
                db.Open();
                var sql = "INSERT INTO Product (Id,Name, Price, Stock) VALUES (@Id,@Name, @Price, @Stock)";
                db.Execute(sql, product);
                Console.WriteLine("Product added successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void DeleteProduct(int Id) {
            try
            {
                db.Open();
                var sql = "DELETE FROM Product WHERE Id = @Id";
                db.Execute(sql, Id);
                Console.WriteLine("Product deleted successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void UpdateProduct(Product product)
        {
            try
            {
                db.Open();
                var sql = "UPDATE Product SET  Price = @Price, Stock = @Stock WHERE Id = @Id";
                db.Execute(sql, product);
                Console.WriteLine("Product updated successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void CountProducts()
        {
            try
            {
                db.Open();
                var count = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Product");
                Console.WriteLine($"Total number of products: {count}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void GetAllProductsUsingProcedure()
        {
            try
            {
                db.Open();
                var products = db.Query<Product>("GetAllProducts").ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void GetProductByIdUsingProcedure(int id)
        {
            try
            {
                db.Open();
                var product = db.QuerySingle<Product>("GetProductById", new { ProductId = id }, commandType: CommandType.StoredProcedure);
                if (product != null)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                else
                {
                    Console.WriteLine($"No product found with Id: {id}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        //Anonymous Parameters in Dapper
        private void GetProductByIdAndNameUsingAnonymousParameters(int id,string name)
        {
            try
            {
                var sql= "SELECT * FROM Product WHERE Id = @Id AND Name = @Name";
                db.Open();
                var product = db.QuerySingle<Product>(sql, new { Id = id,Name=name });
                if (product != null)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                else
                {
                    Console.WriteLine($"No product found with Id: {id}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                //program.AddProduct(new Product
                //{
                //    Id=1,
                //    Name = "Sample Product",
                //    Price = 100,
                //    Stock = 50
                //});
               // program.CountProducts();
                //program.GetAll();
                //program.GetAllProductsUsingProcedure();
               // program.GetProductByIdUsingProcedure(1);
               program.GetProductByIdAndNameUsingAnonymousParameters(1, "Sample Product");

                Console.WriteLine("Enter the Id of the product you want to fetch:");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    program.GetById(id);
                }
                else
                {
                    Console.WriteLine("Invalid Id entered.");
                }
                Console.WriteLine("Enter the Id of the product you want to delete:");
                if (int.TryParse(Console.ReadLine(), out int deleteId))
                {
                    program.DeleteProduct(deleteId);
                }
                else
                {
                    Console.WriteLine("Invalid Id entered.");
                }
                Console.WriteLine("Enter the Id of the product you want to update:");
                int Id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Price:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Stock:");
                int stock = int.Parse(Console.ReadLine());
                program.UpdateProduct(new Product
                {
                    Id = Id,
                    Price = price,
                    Stock = stock
                });

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
