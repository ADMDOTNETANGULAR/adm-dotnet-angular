using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnRecords
{
    //comparison between classes and records
    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public record PersonRecord
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Demo2
    {
        static void Main()
        {
            var person1 = new PersonClass() { Age = 12, Name = "Raj" };
            var person2 = new PersonClass() { Age = 12, Name = "Raj" };
            Console.WriteLine(person1==person2); //False: (reference equality)
            //Even though the property values are the same,
            //they are different objects in memory, so == compares references.
            var person3 = new PersonRecord() { Age = 12, Name = "Raj" };
            var person4 = new PersonRecord() { Age = 12, Name = "Raj" };
            Console.WriteLine(person4==person3); //True: (value equality)
            //Records compare values of all properties automatically.
            //If all properties match, the instances are considered equal.

            //copy with changes(not supproted by class)
            var person5 = person4 with { Age = 15 };
            Console.WriteLine(person5);

        }
    }
}
