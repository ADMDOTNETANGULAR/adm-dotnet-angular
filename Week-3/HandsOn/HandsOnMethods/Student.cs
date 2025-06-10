using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    internal class Student
    {
        //instance fields are unique to each instance of the class
        //instance fields are declared without the static keyword
        //instance fields are used to store data that is unique to each instance of the class
        //instance methods can only be called on an instance of the class
        public string name;
        public  int marks;
        //static fields are shared across all instances of the class
        //static fields are declared with the static keyword
        //static fields are used to store data that is common to all instances of the class
        //static methods can be called without creating an instance of the class
        public static string schoolName;
        public static string GetSchoolName()
        {
            //static methods can access static fields directly
            return schoolName;
        }
        public string CheckResult()
        {
            return marks >= 50 ? "Pass" : "Fail"; // This method checks if the student has passed or failed based on marks.
        }
    }
    class Test_Student
    {
        static void Main(string[] args)
        {
            // Create an instance of the Student class
            Student student1 = new Student();
            student1.name = "John Doe";
            student1.marks = 75;
            Student.schoolName = "ABC High School"; // Set the static field
            // Display student information
            Console.WriteLine($"Student Name: {student1.name}");
            Console.WriteLine($"Marks: {student1.marks}");
            Console.WriteLine($"School Name: {Student.GetSchoolName()}"); // Call static method to get school name
            Console.WriteLine($"Result: {student1.CheckResult()}"); // Check and display result
            Student student2 = new Student();
            student2.name = "Jane Smith";
            student2.marks = 45;
            // Display student information for the second student
            Console.WriteLine($"\nStudent Name: {student2.name}");
            Console.WriteLine($"Marks: {student2.marks}");
            Console.WriteLine($"School Name: {Student.GetSchoolName()}"); // Call static method to get school name
            Console.WriteLine($"Result: {student2.CheckResult()}"); // Check and display result
            // Demonstrating static field access
            Console.WriteLine($"\nAll students belong to: {Student.schoolName}");
        }
    }
}
