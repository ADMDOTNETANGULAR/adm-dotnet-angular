using HandsOnEagerAndLazyLoading.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace HandsOnEagerAndLazyLoading
{
    internal class Program
    {
        public static void EagerLoading()
        {
            //Eager Loading: // Loading related data at the same time as the main entity query in a single query using Include().
            using (var context = new MyContext())
            {
                // Eager loading using Include
                var categoriesWithProducts = context.Categories
                    .Include(c => c.Products)
                    .ToList();
                foreach (var category in categoriesWithProducts)
                {
                    Console.WriteLine($"Category: {category.CategoryName}");
                    foreach (var product in category.Products)
                    {
                        Console.WriteLine($"  Product: {product.Name}");
                    }
                }
                Console.WriteLine();
                var productsWithOrders = context.Products
                    .Include(p => p.Orders)
                    .ToList();
                foreach (var product in productsWithOrders)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                    foreach (var order in product.Orders)
                    {
                        Console.WriteLine($"  Order ID: {order.OrderId}, Order Date: {order.OrderDate}");
                    }
                }
                    // Eager loading with multiple levels
                    // Loading related data at multiple levels using ThenInclude.
                    // This will load Orders with their associated Products and Categories.
                    var ordersWithProductsAndCategories = context.Orders
                    .Include(o => o.Product)
                        .ThenInclude(p => p.Category)
                    .ToList();
                foreach (var order in ordersWithProductsAndCategories)
                {
                    Console.WriteLine($"Order ID: {order.OrderId}, Product: {order.Product.Name}, Category: {order.Product.Category.CategoryName}, Order Date: {order.OrderDate}");
                }

            }
        }
        public static void LazyLoading()
        {
            // Lazy Loading: // Loading related data on-demand when accessed.
            using (var context = new MyContext())
            {
                // Lazy loading using virtual navigation properties
                var products = context.Products.ToList();
                //var orders=products.SingleOrDefault(p => p.Name == "Laptop")?.Orders;
                //var oders2 = context.Products
                //    .Where(p => p.Price>100)
                //    .SelectMany(p => p.Orders)
                //    .ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                    // Accessing the Orders property will trigger lazy loading
                    foreach (var order in product.Orders)
                    {
                        Console.WriteLine($"  Order ID: {order.OrderId}, Order Date: {order.OrderDate}");
                    }
                }
            }
        }
        public static void ExplicitLoading()
        {
            //Explicit Loading: // Loading related data explicitly using Load() method.
            using (var context = new MyContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Name == "Laptop");
                if (product != null)
                {
                    // Explicitly loading the Orders for the product
                    context.Entry(product).Collection(p => p.Orders).Load();
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                    foreach (var order in product.Orders)
                    {
                        Console.WriteLine($"  Order ID: {order.OrderId}, Order Date: {order.OrderDate}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //EagerLoading();
            // LazyLoading();
            ExplicitLoading();
            // Note: Ensure that the database is created and seeded with initial data before running the code.
            // You can use migrations to create the database schema and seed data.
            // For example, run `dotnet ef migrations add InitialCreate` and `dotnet ef database update` in the terminal.
        }
    }
}
