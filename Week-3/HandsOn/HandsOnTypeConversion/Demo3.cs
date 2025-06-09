using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Demo3
    {
        //object to primitive conversions using Convert class
        static void Main()
        {
            //converting object to primitive types using Convert class
            object obj = 100; // object holding an int value
            int k = Convert.ToInt32(obj); // converting object to int using Convert
            double d = Convert.ToDouble(obj); // converting object to double using Convert
            short s = Convert.ToInt16(obj); // converting object to short using Convert
            byte b = Convert.ToByte(obj); // converting object to byte using Convert
            float f = Convert.ToSingle(obj); // converting object to float using Convert
            decimal m = Convert.ToDecimal(obj); // converting object to decimal using Convert
            obj = "true"; // object holding a string value
            bool flag = Convert.ToBoolean(obj); // converting object to bool using Convert
            obj = 'A'; // object holding a char value
            char ch = Convert.ToChar(obj); // converting object to char using Convert
            //converrting object to premitive types unboxing
            obj = "100"; // object holding a string value
            k = (int)obj; // unboxing: converting object to int (explicit conversion)
            d = (double)obj; // unboxing: converting object to double (explicit conversion)
            s = (short)obj; // unboxing: converting object to short (explicit conversion)
            b= (byte)obj; // unboxing: converting object to byte (explicit conversion)

        }
    }
}
