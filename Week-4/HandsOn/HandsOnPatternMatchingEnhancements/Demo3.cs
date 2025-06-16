using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{

    internal class Demo3
    {

        public record Person(string Name, int Age);
        static void Main()
        {
            //Property Pattern (C# 8+)
            //Match on object properties inside a pattern.
            Person p = new Person("Virat", 35);
            if (p is { Age: >= 18 })
            {
                Console.WriteLine($"{p.Name} is an adult.");
            }

        }
    }
}
