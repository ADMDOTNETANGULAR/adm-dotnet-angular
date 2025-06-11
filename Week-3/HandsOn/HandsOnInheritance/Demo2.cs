using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Shape
    {
        protected string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public void Note()
        {
            Console.WriteLine($"I am {name}");
        }
    }
    class Circle : Shape
    {
        //passing value to parent class constructor
        //base keyword use to invoke the parant parameter constructor to pass the value
        public Circle(string name):base(name)
        {

        }
        public void Note()
        {
            Console.WriteLine($"I am {name}");
        }
    }
    internal class Demo2
    {
        static void Main()
        {
            Circle c = new Circle("Circle");
            c.Note();
            //here object of Shape class and instance of Circle class
            Shape obj = new Circle("Cirlce"); //access only Shape class members
            obj.Note();
           
        }
    }
}
