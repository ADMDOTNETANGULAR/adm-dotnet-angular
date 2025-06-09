using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWithArrays
{
    internal class Demo1
    {
       static void Main()
        {
            //Mixture of different data types in an array
            object[] mixedArray = { 1, "Hello", 3.14, true, 'A' };
            // Access and print each element of the mixed array
            Console.WriteLine("Mixed array elements:");
            foreach (object item in mixedArray)
            {
                Console.WriteLine(item); // Output: 1, Hello, 3.14, True, A
            }
        }
    }
}
