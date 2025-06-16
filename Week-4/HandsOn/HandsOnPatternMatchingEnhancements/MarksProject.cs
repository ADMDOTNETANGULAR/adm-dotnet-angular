using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{
    internal class MarksProject
    {
        public static string EvaluateMarks(int[] marks) => marks switch
        {
            [>= 90, >= 90, >= 90] => "Excellent in all subjects",
            [< 35, ..] => "Failed in first subject",
            [.., < 35] => "Failed in last subject",
            [var first, var second, var third] when first + second + third > 250 => "Overall Outstanding",
            _ => "Average performance"
        };
        static void Main()
        {
            Console.WriteLine(EvaluateMarks(new[] { 95, 91, 93 })); // Excellent
            Console.WriteLine(EvaluateMarks(new[] { 30, 80, 90 })); // Failed in first
            Console.WriteLine(EvaluateMarks(new[] { 70, 80, 30 })); // Failed in last
            Console.WriteLine(EvaluateMarks(new[] { 85, 90, 88 })); // Overall Outstanding
            Console.WriteLine(EvaluateMarks(new[] { 60, 70, 65 })); // Average
        }
    }
}
