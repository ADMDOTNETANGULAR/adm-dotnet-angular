using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTask
{
    internal class Demo2
    { //Demo on task properties
        static void Main()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Work Done!!");
            });
            task.Wait();
            Console.WriteLine($"Status: {task.Status}");
            Console.WriteLine($"IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"IsFaulted: {task.IsFaulted}");
        }
    }
}
