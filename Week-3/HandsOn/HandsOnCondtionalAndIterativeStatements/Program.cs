
namespace HandsOnCondtionalAndIterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condtional Statements
            // if, else if, else
            int number = 0;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
