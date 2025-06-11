using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Employee
    {
        // This is a private constructor that prevents instantiation of the class from outside
        private Employee()
        {

        }
        public static Employee GetObject()
        {
            // This method returns a new instance of Employee, but it can only be called from within the class
            return new Employee();
        }
        public void Display()
        {
            Console.WriteLine("This is an Employee.");
        }
    }
    internal class Demo3
    {
        static void Main()
        {
            // The following line will cause a compilation error because the constructor is private
           // Employee emp = new Employee(); 
            Console.WriteLine("Cannot create an instance of Employee because the constructor is private.");
            Employee emp=Employee.GetObject(); // This is the correct way to get an instance
            emp.Display(); // This will work and display the message
        }
    }
}
