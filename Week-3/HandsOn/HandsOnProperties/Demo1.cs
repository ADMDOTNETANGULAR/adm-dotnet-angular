using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    //Properties are used to encapsulate the data members of a class.
    //They provide a way to access and modify the data members while keeping them private.
    class Employee
    {
        private int id;
        private string name;
        //defining properties
        public int Id
        {
            get { return id; } //get accessor is used to retrieve the value of the property
            set { id = value; } //set accessor is used to assign a value to the property
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Demo1
    {
        static void Main()
        {
            Employee e1=new Employee();
            e1.Id = 101; //set accessor is called
            e1.Name = "John Doe"; //set accessor is called
            Console.WriteLine($"Id: {e1.Id}"); //get accessor is called
            Console.WriteLine($"Name: {e1.Name}"); //get accessor is called

        }
    }
}
