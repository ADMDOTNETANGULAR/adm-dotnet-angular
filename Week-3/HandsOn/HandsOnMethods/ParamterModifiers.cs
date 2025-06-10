using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    //in C#,method parameter modifiers are used to specify how parameters are passed to methods.
    //There are several parameter modifiers available in C# that can be used to control the behavior of method parameters. These include `ref`, `out`, `in`, and `params`.

    internal class ParamterModifiers
    {
        public static void M(int number)
        {
            number +=5;
        }
        //Ref variable must be initialized before it is passed to the method.
        public static void M1(ref int number)
        {
            number += 5; // This method modifies the value of the number parameter by reference.
        }
        //Out parameters are used to return multiple values from a method.
        public static void GetValues(out int a, out int b)
        {
            a = 10; // Assigning values to out parameters
            b = 20;
        }
        // In parameters are used to pass arguments by reference, but they cannot be modified inside the method.
        public static void InMethod(in int number)
        {
            // number += 5; // This line would cause a compile-time error because 'number' is an in parameter and cannot be modified.
            Console.WriteLine("InMethod called with number: " + number);
        }

    }
    class Test_ParamterModifiers
    {
        static void Main()
        {
            int number = 5;
            Console.WriteLine("Before calling M: " + number);
            // Call the method M with the number variable
            ParamterModifiers.M(number);
            Console.WriteLine("After calling M: " + number); // The value of number remains unchanged because it was passed by value.
            int x = 5;
            Console.WriteLine("Before calling M1: " + x);
            // Call the method M1 with the x variable using ref modifier
            ParamterModifiers.M1(ref x);
            Console.WriteLine("After calling M1: " + x); // The value of x is modified because it was passed by reference.
            int a, b;
            // Call the method GetValues with out parameters
            ParamterModifiers.GetValues(out a, out b);
            Console.WriteLine("Values from GetValues: a = " + a + ", b = " + b); // The out parameters a and b are assigned values inside the method.
            int value = 100;
            Console.WriteLine("Before calling InMethod: " + value);
            // Call the method InMethod with the value variable using in modifier
            ParamterModifiers.InMethod(in value);
            Console.WriteLine("After calling InMethod: " + value); // The value remains unchanged because it was passed as an in parameter, which cannot be modified inside the method.
        }
    }
}
