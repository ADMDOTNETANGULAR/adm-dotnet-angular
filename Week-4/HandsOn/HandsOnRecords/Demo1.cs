using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnRecords
{
    //Non-Positional Records(C#9.0+)
    public record Employee
    {
        public string? Name { get; init; }
        public string? Departmename { get; init; }
        //default constructor
        public Employee() {
            Console.WriteLine("Hello World");
        }
        //parameterized constructor
        public Employee(string Name,string Department)
        {
            this.Name = Name;
            this.Departmename = Department;
        }
        public void M1()
        {
            
            Console.WriteLine("Hello " + Name);
        }

    }
    internal class Demo1
    {
        static void Main()
        {
            var emp= new Employee() { Name="Alice",Departmename="HR"};
            Console.WriteLine(emp.Name);
            emp.M1();
            var emp2 = new Employee("Virat", "IT");
            emp2.M1();

        }
    }
}
