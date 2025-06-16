using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStringAndStringBuilder
{
    //Sealed classes are not inhertied but instantiated.
    public class A
    {
        public void M1() { }
    }
    public sealed class B:A { 
    public void M2() { }
    }
    //public class C:B
    //{

    //}

    internal class Demo1
    {
        static void Main()
        {
            {

            }
        }
    }
}
