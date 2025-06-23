using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    internal class Demo5
    {
        int counter = 0;

        public void Increment()
        {
            for (int i = 0; i < 1000; i++)
            {
                
                Console.WriteLine("Count Value for Thread {0} :{1}", Thread.CurrentThread.Name, counter);
                counter++;
                //Thread.Sleep(500);
            }
        }
        static void Main()
        {
            Demo5 demo = new Demo5();
            Thread t1=new Thread(demo.Increment);
            t1.Name = "T1";
            t1.Start();
            Thread t2=new Thread(demo.Increment);
            t2.Name = "T2";
            t2.Start();
        }
    }
}
