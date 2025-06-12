using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }
        //virtual method to be overridden
        public virtual void Role()
        {
            Console.WriteLine($"{Name} is a regular Employee.");
        }

    }
    class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }
        //overriding the virtual method
        public override void Role()
        {
            Console.WriteLine($"{Name} is a Manager who overseas the team.");
        }
    }
    internal class Demo6
    {
        static void Main()
        {
            Employee emp = null;
            Console.WriteLine("Enter the role of the employee (Manager/Developer): ");
            string role = Console.ReadLine();
            switch (role.ToLower())
            {
                case "manager":
                    emp = new Manager("Alice");
                    emp.Role(); // Calls the overridden method in Manager class
                    break;
                case "developer":
                    emp = new Employee("Bob");
                    emp.Role(); // Calls the base class method
                    break;
                default:
                    Console.WriteLine("Invalid role specified.");
                    break;
            }
        }
    }
}
