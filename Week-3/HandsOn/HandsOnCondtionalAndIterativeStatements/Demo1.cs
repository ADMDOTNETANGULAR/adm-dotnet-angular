using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCondtionalAndIterativeStatements
{
    internal class Demo1
    {
        static void Main()
        {
            //nested if-else statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }
            //finding the largest of three numbers using nested if-else
            int a = 100,b = 20, c = 30;
            if(a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("The largest number is: " + a);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine("The largest number is: " + b);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + c);
                }
            }
        }
    }
}
