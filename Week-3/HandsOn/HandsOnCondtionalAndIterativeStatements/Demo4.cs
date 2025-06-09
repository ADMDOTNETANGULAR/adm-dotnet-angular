using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCondtionalAndIterativeStatements
{
    internal class Demo4
    {
        static void Main()
        {
            //using iterative statements
            //for loop
            Console.WriteLine("Using for loop:");
            for (int i = 1; i <= 5; i++)
            {
                //write your code here
                Console.WriteLine("Iteration: " + i);
            }
            //while loop
            Console.WriteLine("Using while loop:");
            int j = 1;
            while (j <= 5) //pre-condition loop
            {
                //write your code here
                Console.WriteLine("Iteration: " + j);
                j++;
            }
            //do-while loop
            Console.WriteLine("Using do-while loop:");
            int k = 1;
            do //post -condition loop
            {
                //write your code here
                Console.WriteLine("Iteration: " + k);
                k++;
            } while (k <= 5);
            //foreach loop
            Console.WriteLine("Using foreach loop:");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            foreach (string name in names) //iterating through a collection
            {
                //write your code here
                Console.WriteLine("Name: " + name);
            }
            //break and continue statements
            Console.WriteLine("Using break and continue statements:");
            for (int m = 1; m <= 1000; m++)
            {
                if (m == 100)
                {
                    Console.WriteLine("Breaking at iteration: " + m);
                    break; //exit the loop when m is 5
                }
                if (m % 2 == 0)
                {
                    Console.WriteLine("Skipping even number: " + m);
                    continue; //skip the rest of the loop for even numbers
                }
                Console.WriteLine("Odd number: " + m);
            }
            //nested loops
            Console.WriteLine("Using nested loops:");
            for (int x = 1; x <= 3; x++) //outer loop
            {
                for (int y = 1; y <= 2; y++) //inner loop
                {
                    Console.WriteLine($"Outer loop iteration: {x}, Inner loop iteration: {y}");
                }
            }

        }
    }
}
