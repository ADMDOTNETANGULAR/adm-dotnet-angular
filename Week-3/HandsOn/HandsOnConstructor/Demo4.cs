using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Circle
    {
        private static double PI;
        private double radius;
        static Circle()
        {
            Console.WriteLine("Static constructor called to initialize static field PI.");
            PI = 3.14; // Static constructor initializes the static field
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()=> PI * radius * radius; // Method to calculate area of the circle
    }

    internal class Demo4
    {
        static void Main()
        {
            Circle c1 = new Circle(5.0); // Static constructor is called only once
            Circle c2 = new Circle(10.0); // Static constructor is not called again
            Console.WriteLine("Circle objects created successfully.");
            Console.WriteLine("Area of c1: " + c1.Area()); // Outputs: Area of c1: 78.5
            Console.WriteLine("Area of c2: " + c2.Area()); // Outputs: Area of c2: 314.0
        }
    }
}
