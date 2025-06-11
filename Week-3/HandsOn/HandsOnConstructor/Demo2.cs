using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Rectangle
    {
        public int length;
        public int width;
        // Default constructor
        public Rectangle()
        {
            length = 5;
            width = 10;
        }
        // Parameterized constructor
        public Rectangle(int length, int width)
        {
            //this is use to access the class members with in the same class
            this.length = length;
            this.width = width;
        }
        //copy constructor  
        // This constructor initializes a new instance of the Rectangle class using another Rectangle instance.
        public Rectangle(Rectangle r)
        {
            length = r.length;
            width = r.width;
        }
        public int Area()=> length * width;
    }
    internal class Demo2
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle(); // Calls default constructor
            Rectangle r2 = new Rectangle(12, 23); // Calls parameterized constructor
            Console.WriteLine("Area of r1: " + r1.Area()); // Outputs: Area of r1: 50   
            Console.WriteLine("Area of r2: " + r2.Area()); // Outputs: Area of r2: 276
            Rectangle r3 = new Rectangle(r2); // Calls copy constructor
            Console.WriteLine("Area of r3 (copy of r2): " + r3.Area()); // Outputs: Area of r3 (copy of r2): 276
            Rectangle r4 = r2; // shallow copy
            Console.WriteLine("Area of r4 (shallow copy of r2): " + r4.Area()); // Outputs: Area of r4 (shallow copy of r2): 276
            r2.width = 12; // Modifying r2's width
            Console.WriteLine("Area of r2 after modification: " + r2.Area()); // Outputs: Area of r2 after modification: 144
            Console.WriteLine("Area of r4 after r2 modification: " + r4.Area()); // Outputs: Area of r4 after r2 modification: 144
            Console.WriteLine("Area of r3 after r2 modification: " + r3.Area()); // Outputs: Area of r3 after r2 modification: 276
        }
    }
}
