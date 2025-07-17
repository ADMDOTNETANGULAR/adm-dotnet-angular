using RestSharp;
using Newtonsoft.Json;
namespace ConsoleClient
{
    class ProductRepository
    {
        private static readonly RestClient client;
        static ProductRepository()
        {
            client = new RestClient("http://localhost:5197/api/Product"); // Adjust the base URL as needed
        }
        public static void GetAll()
        {
            RestRequest request = new RestRequest("/GetAllProducts", Method.Get); // Use the correct endpoint for getting all products
            RestResponse response = client.Execute(request);// Execute the request
            Console.WriteLine(response.Content); // Print the raw response content
            // Deserialize the response content into a list of Product objects
            var products = JsonConvert.DeserializeObject<List<Product>>(response.Content);
            foreach (var item in products)
            {
                Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Price: {item.Price}");
            }
        }
        public static void Get(int id)
        {
            RestRequest request = new RestRequest("/GetProductById/" + id, Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);// Print the raw response content
            // Deserialize the response content into a Product object
            Product item = JsonConvert.DeserializeObject<Product>(response.Content);
            Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Price: {item.Price}");
        }
        public static void Add(Product product)
        {
            RestRequest request = new RestRequest("/AddProduct", Method.Post);// Use the correct endpoint for adding a product
            request.AddJsonBody(product);// Serialize the product object to JSON and add it to the request body
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public static void Update(Product product)
        {
            RestRequest request = new RestRequest("/UpdateProduct", Method.Put);
            request.AddJsonBody(product);// Serialize the product object to JSON and add it to the request body
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        public static void Delete(int id)
        {
            RestRequest request = new RestRequest("/DeleteProduct/" + id, Method.Delete);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //ProductRepository.GetAll();
           //ProductRepository.Get(10);
           // ProductRepository.Add(new Product {ProductName = "New Product", Price = 100 });
           // ProductRepository.GetAll();
            //ProductRepository.Update(new Product { ProductId = 1, ProductName = "Updated Product", Price = 150 });
            ProductRepository.Delete(1);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
