using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{
    //Synchronization of Threads
    internal class Demo6
    {
        public int count;
        public void Task()
        {

            lock (this)
            {
                count = 0;
                for (int i = 1; i <= 10; i++)
                {
                    count++;
                    Console.WriteLine("Thread {0} Count Value:{1}", Thread.CurrentThread.Name, count);
                    Thread.Sleep(500);
                }
            }
        }
        static void Main()
        {
            Demo6 obj = new Demo6();
            Thread t1 = new Thread(obj.Task);
            t1.Name = "T1";
            Thread t2 = new Thread(obj.Task);
            t2.Name = "T2";
            t1.Start();
            t2.Start(); //t2 will wait for t1 to complete its execution due to lock
        }
    }
}
