using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatternMatchingEnhancements
{
    public abstract record Shape;
    public record Circle(double radius) : Shape;
    public record Rectangle(double width, double height) : Shape;
    public record Square(double side) : Shape;
    public record Triangle(double Base, double height) : Shape;
    internal class Project
    {
        ///Area Calculator Method Using switch Expression
        public static double CalculateArea(Shape shape) =>
            shape switch
            {
                Circle c => Math.PI * c.radius * c.radius,
                Rectangle r => r.height * r.width,
                Square s => 4 * s.side,
                Triangle t when t.Base > 0 && t.height > 0 => 0.5 * t.Base * t.height,
                _ =>throw new Exception("Invalid Shpae")
            };
        static void Main()
        {

            List<Shape> shapes = new()
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3),
            new Triangle(10, 4),
            new Triangle(0, 5) // Invalid dimensions (edge case)
        };
            foreach (var shape in shapes)
            {
                try
                {
                    double area = CalculateArea(shape);
                    Console.WriteLine($"{shape}  Area: {area:F2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{shape}  Error: {ex.Message}");
                }
            }
        }
    }
}
