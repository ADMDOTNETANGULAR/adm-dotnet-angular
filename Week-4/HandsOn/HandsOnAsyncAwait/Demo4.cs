using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Added missing namespace for StreamReader

namespace HandsOnAsyncAwait
{
    internal class Demo4
    {
        public static async Task<int> ReadFile(string path)
        {
            int length = 0;
            Console.WriteLine("File reading is starting..");
            using (StreamReader sr = new StreamReader(path))
            {
                string s = await sr.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("File reading is completed..");
            return length;
        }

        public static async Task CallingMethod() 
        {
            string filepath = "D:\\topics_to_learn.txt";
            int length = await ReadFile(filepath); // Await the ReadFile method directly
            Console.WriteLine("Other Work 1");
            Console.WriteLine("Other Work 2");
            Console.WriteLine("Other Work 3");
            Console.WriteLine("Total Length :" + length);
            Console.WriteLine("After Work 1");
            Console.WriteLine("After Work 2");
        }

        public static async Task Main()
        {
            await CallingMethod(); // Await the CallingMethod to ensure it completes before exiting
            Console.WriteLine("Main method completed after CallingMethod.");
        }
    }
}
