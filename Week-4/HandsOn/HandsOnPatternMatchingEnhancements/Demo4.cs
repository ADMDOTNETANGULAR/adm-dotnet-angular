using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{
    internal class Demo4
    {
        static void Main()
        {
            //List Pattern
            //1.Simple List Match
            int[] numbers = { 1, 2, 3 };
            if (numbers is [1, 2, 3])
            {
                Console.WriteLine("Exact match: [1, 2, 3]");
            }
            //2. Using Wildcard _ to Ignore Elements
            int[] numbers1 = { 1, 2, 99 };

            if (numbers1 is [1, 2, _])
            {
                Console.WriteLine("Starts with 1, 2 and any third number");
            }
            //3. Match with .. (Slice Pattern)
            int[] numbers2 = { 10, 20, 30, 40 };

            if (numbers2 is [10, ..])
            {
                Console.WriteLine("Starts with 10");
            }

            if (numbers2 is [.., 40])
            {
                Console.WriteLine("Ends with 40");
            }

            if (numbers2 is [10, .., 30, 40])
            {
                Console.WriteLine("Starts with 10 and has 30, 40 at the end");
            }
            //4. Length Pattern Matching
            int[] nums = { 1, 2, 3 };

            if (nums is [_, _, _])
            {
                Console.WriteLine("Has exactly 3 elements");
            }
        }
    }
}
