using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{
    internal class Demo1
    {
        static void Main()
        {
            //Basic switch expression
            int age = 18;
            string result = age switch
            {
                < 18 => "Minor",
                >= 18 and <= 60 => "Adult",
                > 60 => "Senior",
                //_ => "Unknown" //unreachable code
            };
            Console.WriteLine(result);
            //Type Pattern in switch
            object obj = 123;
            string description = obj switch
            {
                int n => $"Integer:{obj}",
                string s => $"String:{obj}",
                null => "null value",
                _=>"other type"
            };
            Console.WriteLine($"{description}");
        }
    }
}
