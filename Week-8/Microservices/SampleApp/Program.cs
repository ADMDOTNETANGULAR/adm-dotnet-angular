namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for(int i=5;i>0;i--)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of 5 is: " + result);
        }
    }
}
