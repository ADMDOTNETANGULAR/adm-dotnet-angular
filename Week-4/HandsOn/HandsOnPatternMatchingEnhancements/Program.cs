namespace HandsOnPatternMatchingEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //is Pattern Matching
            //Type Pattern 
            object obj = "Hello";
            if (obj is string s)
            {
                Console.WriteLine($"String length: {s.Length}");
            }
            //Constant Pattern
            int num = 10;
            if (num is 10)
            {
                Console.WriteLine("Exactly 10");
            }
            //Relational Pattern (C# 9+)
            int age = 18;
            if (age is >= 18 and <= 60)
            {
                Console.WriteLine("Eligible for work");
            }

        }
    }
}
