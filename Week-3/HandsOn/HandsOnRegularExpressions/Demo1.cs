using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpressions
{
    internal class Demo1
    {
        static void Main()
        {
            string mobile = "9876765456";
            string pattern = @"\d{10}"; //match 10 digin number
            Match match= Regex.Match(mobile, pattern);
            if (match.Success)
            {
                Console.WriteLine("Mobile No: "+match.Value);
            }
            else
            {
                Console.WriteLine("Invalid Mobile No");
            }


        }
    }
}
