using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    //Demonstration of Thread Priority
    internal class Demo7
    {
        public static void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Task1 is Running...");
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
            t1.Priority = ThreadPriority.Highest; // Setting priority for t1
            t1.Start();
            t2.Priority = ThreadPriority.Lowest;// Setting priority for t2
            t2.Start();
            Console.WriteLine("Main Thread Running..");


        }
    }
}
