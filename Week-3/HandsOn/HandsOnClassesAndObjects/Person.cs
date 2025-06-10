using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    //clsss can be defined with access modifier like public and internal
    //default access modifier for class is internal
    internal class Person
    {
        //fields are variables that are defined inside a class
        //Files (Data Hiding)
        private string name; //private field, accessible only within the class
        private int age; //private field, accessible only within the class
        //constutror(used to initialize the object)
        public Person(string name, int age)
        {
            this.name = name; // 'this' refers to the current instance of the class
            this.age = age; // 'this' refers to the current instance of the class
        }
        //public method to display the person's details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
        //Getters and Setters (Properties)
        public string Name
        {
            get { return name; } // Getter for name
            set { name = value; } // Setter for name
        }

    }
}
