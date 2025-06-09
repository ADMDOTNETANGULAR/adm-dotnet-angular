using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWithArrays
{
    internal class Demo3
    {
        static void Main()
        {
            // Declare two-dimensional array (matrix)
            int[,] two_dimensional = new int[2, 3];
            // Assign values to the two-dimensional array
            two_dimensional[0, 0] = 1;
            two_dimensional[0, 1] = 2;
            two_dimensional[0, 2] = 3;
            two_dimensional[1, 0] = 4;
            two_dimensional[1, 1] = 5;
            two_dimensional[1, 2] = 6;
            // Access and print elements of the two-dimensional array
            Console.WriteLine("Two-dimensional array elements:");
            for (int i = 0; i < two_dimensional.GetLength(0); i++) // GetLength(0) gives the number of rows
            {
                for (int j = 0; j < two_dimensional.GetLength(1); j++) // GetLength(1) gives the number of columns
                {
                    Console.Write(two_dimensional[i, j] + " "); // Output: 1 2 3 4 5 6
                }
                Console.WriteLine(); // New line after each row
            }
        }
    }
}
