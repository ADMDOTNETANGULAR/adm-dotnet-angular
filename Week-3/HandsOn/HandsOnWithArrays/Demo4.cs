using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWithArrays
{
    internal class Demo4
    {
        static void Main()
        {
            // Declare and initialize a jagged array (array of arrays)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            //access and print the first element of the jagged array
            Console.WriteLine("First element of the jagged array: " + jaggedArray[0][0]); // Output: 1
            // Access and print elements of the jagged array
            Console.WriteLine("Jagged array elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " "); // Output: 1 2 3, 4 5, 6 7 8 9
                }
                Console.WriteLine(); // New line after each row
            }
        }
    }
}
