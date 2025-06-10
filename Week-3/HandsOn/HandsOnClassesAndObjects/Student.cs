using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    public class Student
    {
        //Private is the default access modifier for class members
        // Fields
        public int Id;
        public string Name;
        public string Address;
        public void Introduce() // Method to introduce the student
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Address: {Address}");
        }

    }
    class Test_Student()
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Student class
            Student student = new Student();
            // Initializing the fields
            student.Id = 1;
            student.Name = "Alice";
            student.Address = "123 Main St";
            // Calling the method to introduce the student
            student.Introduce(); // Output: Id: 1, Name: Alice, Address: 123 Main St
            Student s1= new Student(); // Creating another instance of Student
            s1.Introduce(); // Output: Id: 0, Name: , Address:
            //Object Initializer Syntax
            Student s2 = new Student{ Address = "789 Oak St", Id = 3, Name = "Charlie" };
            //Array of Students
            Student[] students = new Student[3]; // Array to hold 3 Student objects
            // Initializing the array with Student objects
            students[0] = new Student { Id = 2, Name = "Bob", Address = "456 Elm St" };
            students[1] = new Student { Id = 3, Name = "Charlie", Address = "789 Oak St" };
            students[2] = new Student { Id = 4, Name = "David", Address = "101 Pine St" };
            students[0].Introduce(); // Output: Id: 2, Name: Bob, Address: 456 Elm St
            // Displaying the details of each student in the array
            foreach (Student stu in students)
            {
                stu.Introduce(); // Output: Id: 2, Name: Bob, Address: 456 Elm St
                                 //         Id: 3, Name: Charlie, Address: 789 Oak St
                                 //         Id: 4, Name: David, Address: 101 Pine St
            }
        }
    }

}
