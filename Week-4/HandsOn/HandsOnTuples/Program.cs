using System.Net.Cache;

namespace HandsOnTuples
{
    internal class Program
    {
        //3. Returning Multiple Values from a Method
        public static (int min,int max) FindMinMix(int[]numbers)
        {
            int min = numbers.Min();
            int max= numbers.Max();
            return (min,max);
        }
        //Swappign two numbers
        public static (int, int) Swap(int a, int b) => (b, a);
        static void Main(string[] args)
        {
            //old way to use tuple
            Tuple<int, string> t = new Tuple<int, string>(1, "Hello");
            Console.WriteLine(t.Item1);  // Output: 1
            //modern way to use tuple
            var person = ("John", 25); //1. Creating a Tuple(C# 7.0 and later)
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            // 2.Named Elements for Better Readability
            var student = (Name: "Viart", Age: 25);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            var result = FindMinMix(new int[] { 12, 23, 34, 45 });
            Console.WriteLine($"Min: {result.min}, Max: {result.max}");
            //4.Deconstructing a Tuple (Deconstruct to variables)
            var (name, age) = ("Virat", 25);
            Console.WriteLine($"Name:{name} Age:{age}");
            var (min, max) = FindMinMix(new int[] { 12, 34, 45 });
            Console.WriteLine($"Min: {min}, Max: {max}");
            var (x, y) = Swap(10, 20);
            Console.WriteLine($"x = {x}, y = {y}");  // Output: x = 20, y = 10
        }
    }
}
