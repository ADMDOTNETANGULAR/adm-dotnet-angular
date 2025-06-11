namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int num = null;// This will cause a compile-time error because 'null' cannot be assigned to an int
            int ? nullableNum = null; // This is valid because nullableNum is of type int? (nullable int)

        }

    }
}
