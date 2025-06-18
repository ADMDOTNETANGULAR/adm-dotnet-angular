using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate int CubeDelegate(int i);
    internal class Demo2
    {
        public void Callback(CubeDelegate cubeDelegate)
        {
            Console.WriteLine(cubeDelegate(8));
        }
        public int Cube(int i) => i * i * i;
        static void Main()
        {
            Demo2 demo = new Demo2();
            demo.Callback(demo.Cube);
            demo.Callback(i => i * i * i);

        }
    }
}
