using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Demo2
    {
        //conversion using Convert class
        static void Main()
        {
            //string conversions using Convert class
            string str = "100";
            int k = Convert.ToInt32(str); // converting string to int using Convert
            double d = Convert.ToDouble(str); // converting string to double using Convert
            short s = Convert.ToInt16(str); // converting string to short using Convert
            byte b = Convert.ToByte(str); // converting string to byte using Convert
            float f = Convert.ToSingle(str); // converting string to float using Convert
            decimal m = Convert.ToDecimal(str); // converting string to decimal using Convert
            bool flag = Convert.ToBoolean("true"); // converting string to bool using Convert
            char ch = Convert.ToChar("A"); // converting string to char using Convert
            //Premitive to primitive conversions using Convert class
            k = 100;
            d = Convert.ToDouble(k); // implicit conversion from int to double using Convert
            s= Convert.ToInt16(k); // explicit conversion from int to short using Convert
            b = Convert.ToByte(k); // explicit conversion from int to byte using Convert
            d = 34.56;
            k = Convert.ToInt32(d); // explicit conversion from double to int using Convert

        }
    }
}
