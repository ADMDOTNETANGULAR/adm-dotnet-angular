using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HandsOnMultiThreading
{
    internal class Demo0
    {
        public static void Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task 1 - Count: " + i);
                Thread.Sleep(100); // Simulate work
            }
        }
        static void Main()
        {
            //Task1();// Call Task1 directly in the main thread
            Thread t1 = new Thread(Task1); // Create a new thread for Task1
            t1.Start(); // Start the thread

            Console.WriteLine("Main thread is running concurrently with Task1.");
        }
    }
}
