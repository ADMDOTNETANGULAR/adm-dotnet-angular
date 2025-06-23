using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{ // Demonstration of Race Condition
    // This example shows how multiple threads can modify a shared variable without synchronization, leading to unpredictable
    // results. The counter variable is incremented by two threads simultaneously, which can result in a final value that is less than expected.
    //Use lock, Monitor, Mutex, or Interlocked
    internal class Demo11
    {
        static int counter = 0;

        static void Increment()
        {
            for (int i = 0; i < 1000; i++)
            {
                counter++; // Not thread-safe
              
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
