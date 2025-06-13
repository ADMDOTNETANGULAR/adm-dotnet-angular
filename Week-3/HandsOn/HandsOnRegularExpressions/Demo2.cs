using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HandsOnRegularExpressions
{
    internal class Demo2
    {
        static void Main()
        {
            string password="pass1";
            //allow password with 5 char long
            string pattern = @"^[a-zA-Z0-9]{5}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Password is :" + password);
            }
            else
            {
                Console.WriteLine("Invlaid Password");
            }

        }
    }
}
