using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractClasses
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }
        public abstract void CalculateSalary(); // Abstract method to calculate salary
        public  void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }
    }
    class Manager:Employee
    {
        public double Bonus { get; set; }
        public Manager(string name,double bonus) : base(name) {
        Bonus = bonus; // Initialize bonus for the manager
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"{Name} is a Manager. Salary includes a monthly bonous of {Bonus}");
        }
       
    }
    internal class Demo1
    {
        static void Main()
        {
            // Create an instance of Manager
                Employee manager = new Manager("Alice",5000);
                manager.DisplayInfo(); // Display employee info
                manager.CalculateSalary(); // Calculate salary for the manager
        }
    }
}
