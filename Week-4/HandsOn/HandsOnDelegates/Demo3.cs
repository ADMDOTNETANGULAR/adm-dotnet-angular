using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void EventHandlerDelegate();
    internal class Demo3
    {
        public void Task()
        {
            Console.WriteLine("Task is runnit when event fire");
        }
        //define events
        public event EventHandlerDelegate myevent;
        public void EventCall()
        {
            myevent.Invoke();//calling event
        }
        static void Main()
        {
            Demo3 obj=new Demo3();
            obj.myevent=obj.Task;//task is invoke when event fire
           obj.EventCall(); //assume like click button or change item in dropdown
        }
    }
}
