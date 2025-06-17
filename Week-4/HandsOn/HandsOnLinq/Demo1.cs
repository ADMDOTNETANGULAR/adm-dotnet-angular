using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo1
    {
        static void Main()
        {
            string[] cities = { "Pune", "Chennai", "Hyderabad", "Banglore", "Delhi", "Bopal" };
            //fetch cities with lenght >4
            var result=from c in cities
                       where c.Length>4
                       select c.ToUpper();
            //fetch cities starts with B
             result=from c in cities
                       where c.StartsWith("B")
                       select c.ToUpper();
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
