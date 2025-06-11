using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    //Properties are used to compute values dynamically.
    internal class Circle
    {
        private double radius;
        private const double pi = 3.14; //constant for Pi value
        //public double Radius //read -write property for radius
        //{
        //    get { return radius; } //get accessor returns the value of radius
        //    set { radius = value; } //set accessor assigns a value to radius
        //}
        public double Radius //write-only property for radius
        {
            set { radius = value; } //set accessor assigns a value to radius
        }
        //Property to calculate the area of the circle
        public double Area //read-only property for area
        {
            get { return pi * radius * radius; } //get accessor calculates and returns the area
        }
    }
    class Demo2
    {
        static void Main()
        {
            Circle c1 = new Circle();
            c1.Radius = 5; //set accessor is called to assign radius
            Console.WriteLine($"Area of the circle:{c1.Area}"); //get accessor is called to calculate area
        }
    }
}
