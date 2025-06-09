using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Demo1
    {
        static void Main()
        {
            //string conversions
            string str = "100";
            int k = int.Parse(str); // converting string to int using Parse
            double d = double.Parse(str); // converting string to double using Parse
            short s = short.Parse(str); // converting string to short using Parse
            byte b = byte.Parse(str); // converting string to byte using Parse
            float f = float.Parse(str); // converting string to float using Parse
            decimal m = decimal.Parse(str); // converting string to decimal using Parse
            bool flag = bool.Parse("true"); // converting string to bool using Parse
            char ch= char.Parse("A"); // converting string to char using Parse
        }
    }
}
