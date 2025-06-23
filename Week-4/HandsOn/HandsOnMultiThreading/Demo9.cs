using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    // Demonstration of Background Threads
    internal class Demo9
    {
        public static void Task()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        static void Main()
        {
            Thread t = new Thread(Task);
           t.IsBackground = true; // Setting the thread as a background thread
            // Background threads do not prevent the application from exiting
            t.Start();
            t.Join(1000);
            Console.WriteLine("MainThread Running..");
            Console.WriteLine("End Task");
        }
    }
}
