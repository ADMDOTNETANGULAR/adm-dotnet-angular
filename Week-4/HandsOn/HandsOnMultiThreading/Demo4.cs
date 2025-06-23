using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMultiThreading
{

    class Demo4
    {
        public int count;
        public void Task()
        {
            try
            {
                for (int i = 1; i <= 100000; i++)
                {
                    Console.WriteLine("Count Value:{0}", count);
                    count++;
                    Thread.Sleep(500);
                    if (i == 10)
                    {
                        Console.WriteLine("Stop Thread");
                        return;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main()
        {
            try
            {
                Demo4 ob = new Demo4();
                Thread t = new Thread(ob.Task);
                t.Start();
                t.Join(500);
                Console.WriteLine("Main Thread is Running..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

