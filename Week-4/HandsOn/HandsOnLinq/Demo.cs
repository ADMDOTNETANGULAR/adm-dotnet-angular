using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo
    {
        static void Main()
        {
            //anonymous object
            var emp = new {Id=3833,Name="Rohan"};
            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
        }

    }
}
