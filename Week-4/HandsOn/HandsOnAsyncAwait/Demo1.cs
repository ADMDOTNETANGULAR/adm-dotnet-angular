using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAsyncAwait
{
    internal class Demo1
    {
        static async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");

        }
        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
        static void Main(string[] args)
        {
            LongProcess();
            ShortProcess();
            Console.ReadKey();
        }
    }
}
