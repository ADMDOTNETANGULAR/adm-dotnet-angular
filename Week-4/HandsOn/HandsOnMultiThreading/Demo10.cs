using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    internal class Demo10
    {
        // Demonstration of Thread States
        static void DoWork()
        {
            Console.WriteLine("Thread is working...");
            Thread.Sleep(2000); // Simulate work
            Console.WriteLine("Thread completed work.");
        }
        static void Main()
        {
            Thread t = new Thread(DoWork);

            Console.WriteLine($"Initial Thread State: {t.ThreadState}"); // Unstarted

            t.Start();
            Thread.Sleep(500); // Allow time for the thread to start

            Console.WriteLine($"Thread State after Start: {t.ThreadState}");

            t.Join(); // Wait for thread to complete

            Console.WriteLine($"Thread State after Completion: {t.ThreadState}");
        }

    }
}
