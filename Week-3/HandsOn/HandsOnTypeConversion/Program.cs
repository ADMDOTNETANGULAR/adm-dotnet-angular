namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //casting in c#(converting in between primitives)
            int k = 100;
            double d = k; // implicit conversion from int to double
            Console.WriteLine($"Implicit conversion from int to double: {d}");
            byte b = (byte)k; // explicit conversion from int to byte
            b= (byte)d; // explicit conversion from double to byte
            short s = (short)k; // explicit conversion from int to short
            d = 34.56;
            k= (int)d; // explicit conversion from double to int
            b = (byte)d; // explicit conversion from double to byte
            s= (short)d; // explicit conversion from double to short
        }
    }
}
