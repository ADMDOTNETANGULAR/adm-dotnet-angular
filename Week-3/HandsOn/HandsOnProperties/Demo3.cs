using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    //Properties also use to  validation of data before assigning it to a field.
    class Student
    {
      private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                age = value;
            }
        }
    }
    internal class Demo3
    {
        static void Main()
        {
            try
            {
                Student s1 = new Student();
                s1.Name = "Alice"; //set accessor is called
                s1.Age = 20; //set accessor is called
                Console.WriteLine($"Name: {s1.Name}"); //get accessor is called
                Console.WriteLine($"Age: {s1.Age}"); //get accessor is called
            // Uncommenting the following lines will throw exceptions
                s1.Name = ""; //will throw ArgumentException
                s1.Age = -5; //will throw ArgumentOutOfRangeException
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
