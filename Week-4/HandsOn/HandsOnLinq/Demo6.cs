using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    public record Student(int id,string name);
    public record Enroll(int id,string course);
    public record StudentEnroll(int id,string name,string course);
    internal class Demo6
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"Ram"),
                new Student(2,"Tina"),
                new Student(3,"Taran")
            };
            List<Enroll> enrolls = new List<Enroll>()
            {
                new Enroll(1,"Dotnet"),
                 new Enroll(2,"Java"),
                  new Enroll(3,"Python"),
                   new Enroll(1,"Azure"),
                    new Enroll(2,"AWS"),
                     new Enroll(3,"GCP"),
            };
            //Joining 2 data source
            var result = from student in students
                         join enroll in enrolls
                         on student.id equals enroll.id
                         select new StudentEnroll(student.id, student.name, enroll.course);
            foreach(var item in result)
                Console.WriteLine($"Id:{item.id} Name:{item.name} course:{item.course}");
        }
    }
}
