using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTask
{
    internal class Demo1
    {
        static void DoWork(string taskName, int delay)
        {
            for (int i = 0; i <= 3; i++)
            {
                Task.Delay(delay).Wait(); // Simulating some work
                Console.WriteLine($"taskname {taskName}-Step {i+1} done!!");
            }

        }
        static  void Main()
        {
            //mutiple tasks running in parallel
            Task task1 = Task.Run(() => DoWork("task1", 1000));
            Task task2= Task.Run(() => DoWork("task2", 2000));
            Task task3 = Task.Run(() => DoWork("task3", 1500));
            //Waiting for all tasks to complete
            Task.WaitAll(task1, task2, task3); //Blocks Main method until all tasks are finished.
            Console.WriteLine("All tasks finished");
        }
    }
}