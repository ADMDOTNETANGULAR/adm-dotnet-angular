using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnRecords
{
    //Mini Project: Student Grade Report Using Records
    public record Student(string Name, int Marks);
    internal class Project
    {
        public static void Main()
        {
            List<Student> students = new()
        {
            new Student("Akhil", 85),
            new Student("Bhavna", 42),
            new Student("Chaitanya", 77),
            new Student("Deepa", 30),
            new Student("Eshwar", 65)
        };
            Console.WriteLine("All Students:");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} - {s.Marks} marks");
            Console.WriteLine("\nPassed Students (Marks >= 50):");
            var passed = students.Where(s => s.Marks >= 50);
            foreach (var s in passed)
                Console.WriteLine($"{s.Name}");
            Console.WriteLine("\nFailed Students (Marks < 50):");
            var failed = students.Where(s => s.Marks < 50);
            foreach (var s in failed)
                Console.WriteLine($"{s.Name}");
            //Update a Student's Marks Using with
            // Assume Deepa wrote a re-exam and scored 55
            var updatedStudent = students.First(s => s.Name == "Deepa") with { Marks = 55 };
            Console.WriteLine($"\nUpdated: {updatedStudent.Name}'s new marks: {updatedStudent.Marks}");
            // Update the list
            students[students.FindIndex(s => s.Name == "Deepa")] = updatedStudent;
            //Updated list
            foreach (var s in students)
                Console.WriteLine($"{s.Name} - {s.Marks} marks");
        }
    }
}
