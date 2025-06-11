using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class A
    {
        public void M1() { }
    }
    class B:A
    {
        public void M2() { }
    }
    class C:B
    {
        public void M3() { }
    }
    internal class Demo3
    {
        static void Main()
        {
            A a = new A(); //less derived
            a.M1();
            B b = new B();
            b.M1();
            b.M2();
            C c = new C(); //more derived
            c.M1();
            c.M2();
            c.M3();


        }
    }
}
