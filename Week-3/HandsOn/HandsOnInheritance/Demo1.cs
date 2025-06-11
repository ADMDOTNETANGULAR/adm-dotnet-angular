using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class X
    {
        public X()
        {
            Console.WriteLine("X constructor called");
        }
    }
    class Y:X
    {
        public Y()
        {
            Console.WriteLine("Y constructor called");
        }
    }
    internal class Demo1
    {
        static void Main()
        {
            Y y= new Y(); // When we create an instance of Y, it will also call the constructor of X first
            // Output will be:
            // X constructor called
            // Y constructor called
           
        }
    }
}
