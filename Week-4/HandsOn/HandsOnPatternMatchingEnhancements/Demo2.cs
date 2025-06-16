using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{
    internal class Demo2
    {
        static void Main()
        {
            // Logical Patterns(C# 9+)
            //Combine and, or, not with is.
            int score = 75;
            if (score is >= 50 and < 60)
                Console.WriteLine("Just passed");
            if (score is not < 50)
                Console.WriteLine("Not a fail");
            //when Guards in switch
            //Add additional conditions.
            object obj = 4;
            string msg = obj switch
            {
                int n when n % 2 == 0 => "Even Number",
                int n => "Odd Number",
                _ => "Not a Number"
            };
            Console.WriteLine(msg);



        }
    }
}
