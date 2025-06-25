using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.LSP
{
    //#region WithOut LSP

  

    //class Rectangle
    //{
    //    public virtual int Width { get; set; }
    //    public virtual int Height { get; set; }

    //    public int GetArea()
    //    {
    //        return Width * Height;
    //    }
    //}

    //class Square : Rectangle
    //{
    //    public override int Width
    //    {
    //        set { base.Width = base.Height = value; } // Modifies both width & height
    //    }
    //    public override int Height
    //    {
    //        set { base.Width = base.Height = value; } // Modifies both height & width
    //    }
    //}

    //// Test function
    //class Program
    //{
    //    static void PrintArea(Rectangle rect)
    //    {
    //        rect.Width = 4;
    //        rect.Height = 5;
    //        Console.WriteLine($"Area: {rect.GetArea()}"); // Expected: 20
    //    }

    //    static void Main()
    //    {
    //        Rectangle rect = new Rectangle();
    //        PrintArea(rect); // Output: Area: 20

    //        Rectangle sq = new Square();
    //        PrintArea(sq); // Output: Area: 25 (Unexpected!)
    //    }
    //}
    //#endregion
    #region With LSP
    
interface IShape
    {
        int GetArea();
    }

    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : IShape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public int GetArea()
        {
            return Side * Side;
        }
    }

    // Test function
    class Program
    {
        static void PrintArea(IShape shape)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }

        static void Main()
        {
            IShape rect = new Rectangle(4, 5);
            PrintArea(rect); // Output: Area: 20

            IShape sq = new Square(4);
            PrintArea(sq); // Output: Area: 16
        }
    }

    #endregion
    internal class Demo2
    {
    }
}
