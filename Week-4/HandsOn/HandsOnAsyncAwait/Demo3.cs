using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsyncAwait
{
    internal class Demo3
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1");
                    count++;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2");

            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total Count: " + count);
        }
        public static async Task CallingMethod()
        {
            Method2();// This will run Method2 synchronously
            var count = await Method1(); // This will wait for Method1 to complete
            Method3(count);// This will run Method3 synchronously with the count returned from Method1
        }
        public static async Task Main()
        {
             await CallingMethod(); // This will wait for CallingMethod to complete
            Console.WriteLine("Main method completed after CallingMethod.");

        }
    }
}
