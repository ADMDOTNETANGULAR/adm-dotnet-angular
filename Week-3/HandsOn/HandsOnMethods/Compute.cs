using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    internal class Compute
    {
        // This class demonstrates method overloading, where multiple methods can have the same name but different parameters.
        public static int Add(int a, int b)
        {
            return a + b; // This method adds two integers and returns the result.
        }
        
        public static int Add(int a, int b, int c)
        {
            return a + b + c; // This method adds three integers and returns the result.
        }
        public static double Add(double a, double b)
        {
            return (int)(a + b); // This method adds two doubles and returns the result as an integer.
        }
    }
    class TestCompute
    {
        static void Main(string[] args)
        {
            // Testing the overloaded Add methods
            Console.WriteLine("Add two integers: " + Compute.Add(5, 10)); // Calls the first Add method
            Console.WriteLine("Add three integers: " + Compute.Add(5, 10, 15)); // Calls the second Add method
            Console.WriteLine("Add two doubles: " + Compute.Add(5.5, 10.2)); // Calls the third Add method
        }
    }
}
