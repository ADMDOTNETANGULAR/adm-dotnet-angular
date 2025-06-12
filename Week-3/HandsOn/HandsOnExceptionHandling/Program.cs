namespace HandsOnExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compilation errors are detected at compile time, not runtime and detected by compiler
            Console.WriteLine("Hello, World!");
            //exception handling using try-catch block
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine($"Result: {c}");
                Console.WriteLine("This line will not be executed if an exception occurs above.");
            }
            catch (DivideByZeroException ex)
            {
                //catch block to handle DivideByZeroException
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
           
        }
    }
}
