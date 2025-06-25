using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.LSP
{
    /* 
     Let’s consider the code below where LSP is violated. We cannot simply substitute a Triangle, 
    which results in the printing shape of a triangle, with a Circle.
     */
    //public class Triangle
    //{
    //    public virtual string GetShape()
    //    {
    //        return "Triangle";
    //    }
    //}

    //public class Circle : Triangle
    //{
    //    public override string GetShape()
    //    {
    //        return "Circle";
    //    }
    //}
    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }
    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
    internal class Demo1
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Circle();
            //Console.WriteLine(triangle.GetShape());
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }
}
