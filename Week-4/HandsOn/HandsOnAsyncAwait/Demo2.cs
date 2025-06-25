using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsyncAwait
{
    internal class Demo2
    {
        // This method is async and returns a Task
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(100).Wait();
                }
            });
        }
        static async Task Main()
        {
            // Method1(); // This will wait for Method1 to complete 
            //Console.WriteLine("Main method completed without waiting for Method1.");
           await Method1();// This will not wait for Method1 to complete
            Console.WriteLine("Main method completed after Method1 Completed.");
        }
    }
}
