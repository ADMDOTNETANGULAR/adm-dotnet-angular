using HandsOnEFUsingCodeFirst.DBContext;
using HandsOnEFUsingCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HandsOnEFUsingCodeFirst
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Add new product row to the Products table
            var product = new Product
            {
                Name="Pen",
                Price= 10.00m
            };
            var context = new AppDbContext();
            context.Products.Add(product); // Add the product to the DbSet
            await context.SaveChangesAsync(); // Save changes to the database
            // Display the added product
            var allProducts=await context.Products.ToListAsync();
            foreach (var p in allProducts)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
            }
        }
    }
}
