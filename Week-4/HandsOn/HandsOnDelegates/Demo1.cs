using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void CallbackDelete();
    internal class Demo1
    {
        public void Task()
        {
            Console.WriteLine("I am Running..");
        }
        public void Callback(CallbackDelete obj)
        {
            obj(); //calling delegate
        }
        static void Main()
        {
            Demo1 demo = new Demo1();
            demo.Callback(demo.Task);//invoking callback function my passing task() as a parameter
            demo.Callback(() => Console.WriteLine("Lamda function"));
        }
    }
}
