namespace HandsOnRecords
{
    //creating and using record.
    public record Person(string FirstName,string LastName);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var person1 = new Person("John", "Die");
            Console.WriteLine($"FirstName:{person1.FirstName} LastName:{person1.LastName}");
            var person2 = new Person("John", "Die");
            Console.WriteLine(person1==person2); //True: Value Equality
            var person3 = person1 with { FirstName = "Virat" };
            Console.WriteLine(person3); //// Output: Person { FirstName = Virat, LastName = Doe }
        }
    }
}
