using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HandsOnMultiThreading
{
    //multiple threads are accessing the same instance value
    class Demo3
    {
        int count = 0;
        public void Task1()
        {
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Count Value for Thread {0} :{1}", Thread.CurrentThread.Name, count);
                    count++;
                    Thread.Sleep(500);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void Task2()
        {
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Count Value for Thread {0} :{1}", Thread.CurrentThread.Name, count);
                    count++;
                    Thread.Sleep(500);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    class Test_Demo3

    {
        static void Main()
        {
           try
            {
                Demo3 obj = new Demo3();
                Thread t1 = new Thread(obj.Task1);
                t1.Name = "T1";
                Thread t2 = new Thread(obj.Task2);
                t2.Name = "T2";
                t1.Start();
                t2.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}
