using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAdo
{
    internal class Demo
    {
        public static void Task1()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Task1 is Running1");
            }
        }
        public static void Task2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task2 is Running1");
            }
        }
        static void Main()
        {
            Task1();
            Task2();
            Console.WriteLine("Main method is running");
        }
    }
}
