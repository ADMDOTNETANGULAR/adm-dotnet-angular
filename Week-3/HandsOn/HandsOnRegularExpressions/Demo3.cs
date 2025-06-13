using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HandsOnRegularExpressions
{
    internal class Demo3
    {
        static void Main()
        {
            //Validate Email
            string email = "John@example.com";
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            bool isValid=Regex.IsMatch(email, pattern);
            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
    }
}
