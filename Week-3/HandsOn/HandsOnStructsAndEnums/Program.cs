namespace HandsOnStructsAndEnums
{
    //define a struct
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z = 900; // Default value for Z
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
    //public struct Point3D: Point // Inheriting from Point is not allowed for structs
    //{
       
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point();
            p1.X = 10;
            p1.Y = 20;
            p1.Display();
            Point p2 = new Point(30, 40); // Using constructor
            p2.Display();
        }
    }
}
