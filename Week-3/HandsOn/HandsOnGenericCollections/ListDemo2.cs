using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Age:{Age}";
        }
    }
    internal class ListDemo2
    {
        static void Main()
        {
            List<Student> list = new List<Student>()
            {
                new Student(){Id=1,Name="Ravi",Age=13},
                new Student(){Id=2,Name="Kiran",Age=13},
                new Student(){Id=3,Name="Kavya",Age=13},
                new Student(){Id=4,Name="Raj",Age=13},
                new Student(){Id=5,Name="Navya",Age=13},
                new Student(){Id=6,Name="Sandeep",Age=13},
            };
            Student s1 = list[3];
            //access student oject using id
            Console.WriteLine("Enter Student Id");
            int id = int.Parse(Console.ReadLine());
            Student s2 = null;
            foreach(Student s in list)
            {
                if(s.Id == id)
                {
                    s2 = s; break;
                }
            }
            if (s2 != null)
            {
                Console.WriteLine(s2);
            }
            else
                Console.WriteLine("Invalid Id");

        }
    }
}
