using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HandsOnMultiThreading
{
    class Demo2
    {
        public static void Greet(object? name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Greet));
            t1.Start("Sachin");
        }
    }
}
