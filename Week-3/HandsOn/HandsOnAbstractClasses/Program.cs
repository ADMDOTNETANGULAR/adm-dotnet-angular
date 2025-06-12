namespace HandsOnAbstractClasses_AbstractClasses
{
    abstract class Shape
    {
        public abstract double Area(); // Abstract method for area calculation
        public void DisplayArea()
        {
            Console.WriteLine($"The area is: {Area()}");
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return Math.PI * radius * radius; // Area of circle: πr²
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double Area()
        {
            return length * width; // Area of rectangle: length * width
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.0);
            circle.DisplayArea();
            Shape rectangle = new Rectangle(4.0, 6.0);
            rectangle.DisplayArea();
        }
    }
}
