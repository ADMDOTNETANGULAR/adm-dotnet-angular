using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HandsOnRegularExpressions
{
    internal class Demo4
    {
        static void Main()
        {
            string text = "Find 123 and 456 in this string";
            string pattern = @"\d+";
            MatchCollection matchers=Regex.Matches(text, pattern);
            foreach (Match m in matchers)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
