using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWithArrays
{
    internal class Demo2
    {
        static void Main()
        {
            // Declare and initialize an array of strings
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            // Access and print the first element of the array
            Console.WriteLine("The first fruit is: " + fruits[0]); // Output: Apple
            // Loop through the array and print each fruit
            Console.WriteLine("All fruits in the array:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]); // Output: Apple, Banana, Cherry, Date, Elderberry
            }
            // Example of using a foreach loop to iterate through the array
            Console.WriteLine("Using foreach loop to print all fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit); // Output: Apple, Banana, Cherry, Date, Elderberry
            }
        }
    }
}
