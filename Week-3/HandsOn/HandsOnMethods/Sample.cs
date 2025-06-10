using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    internal class Sample
    {
        public string Message(string name)
        {
            return "Hello , " + name + "! Welcome to C# methods.";
        }
        public int Multiply(int a, int b=6)
        {
            return a * b; // This method multiplies two integers and returns the result.
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b; // This method divides two doubles and returns the result.
        }
        public void DisplayInfo(string info)
        {
            Console.WriteLine("Information: " + info); // This method displays a string message.
        }
        public bool IsEven(int number)
        {
            return number % 2 == 0; // This method checks if a number is even.
        }
        public int[] PrintNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 }; // This method returns an array of integers.
            return numbers;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.Message("Alice"));
            Console.WriteLine("Multiplication: " + sample.Multiply(5, 10));
            Console.WriteLine("Multiplication: " + sample.Multiply(5)); // Using default parameter value
            Console.WriteLine("Division: " + sample.Divide(20.0, 4.0));
            sample.DisplayInfo("This is a sample method demonstration.");
            Console.WriteLine("Is 4 even? " + sample.IsEven(4));
            Console.WriteLine("Numbers: " + string.Join(", ", sample.PrintNumbers()));
        }
    }
}
