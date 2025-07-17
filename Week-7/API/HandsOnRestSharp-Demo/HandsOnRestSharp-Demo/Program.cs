using RestSharp;
namespace HandsOnRestSharp_Demo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Initialize RestClient and make a GET request
            // to https://jsonplaceholder.typicode.com/posts/1
            var client = new RestClient("https://jsonplaceholder1.typicode.com");
            var request = new RestRequest("/posts/1", Method.Get); // Specify the endpoint and method
            var response = await client.ExecuteAsync(request);// Execute the request asynchronously
            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine($"Status Code: {response.StatusCode}");

            }
        }
    }
}