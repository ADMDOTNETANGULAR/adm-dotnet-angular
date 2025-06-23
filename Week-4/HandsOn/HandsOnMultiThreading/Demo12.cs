using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{ // Demonstration of Thread Synchronization using Lock
    internal class Demo12
    {
        static int counter = 0;
        static readonly object _lock = new object();
        static void Increment()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (_lock)
                {
                    counter++;
                }

            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Final Counter: {counter}");
        }
    }
}
