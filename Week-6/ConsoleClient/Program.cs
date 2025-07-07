using CalculateLibrary;
namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculate calc = new Calculate();
            Console.WriteLine(calc.Add(5, 10));

            Console.WriteLine(calc.Subtract(10, 5));
            Console.WriteLine(calc.Multiply(5, 10));
            Console.WriteLine(calc.Divide(10, 5));
            CalculateLibrary.Currency currency = new CalculateLibrary.Currency();
            Console.WriteLine(currency.ConvertToUSD(100, "EUR"));

        }
    }
}
