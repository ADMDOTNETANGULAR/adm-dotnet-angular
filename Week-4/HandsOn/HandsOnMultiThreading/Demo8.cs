using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    internal class Demo8
    {
        // Demonstration of Thread Join Method
        public static void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Task1 is Running...");
                Thread.Sleep(500); // Simulating work by sleeping for 500 milliseconds
            }
        }
        public static void Task2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Task2 is Running...");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            t1.Start();
            t1.Join(1000);
            t2.Start();
            Console.WriteLine("Main Thread Running..");


        }
    }
}

