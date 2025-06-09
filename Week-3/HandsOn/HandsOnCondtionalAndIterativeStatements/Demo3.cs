using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCondtionalAndIterativeStatements
{
    internal class Demo3
    {
        static void Main()
        {
            //Using switch expression
            int day = 3;
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid day number."
            };
            Console.WriteLine(dayName);
            //Using switch expression with pattern matching
            object obj = 0;
            string result = obj switch
            {
                int i when i > 0 => "Positive integer",
                int i when i < 0 => "Negative integer",
                int i when i == 0 => "Zero",
                _ => "Not an integer"
            };
            Console.WriteLine(result);
        }

    }
}
