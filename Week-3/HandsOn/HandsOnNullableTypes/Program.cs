using System.ComponentModel.Design;

namespace HandsOnNullableTypes
{
    //Nullable types are value types allows null value to assign
    internal class Program
    {
        static void Main(string[] args)
        {
            //int k = null; compilation error
            int? k = null;
            int? price = null;
            int? quantity = 10;
            bool? isAvailable = false;
            Console.WriteLine("Hello, World!");
            int? age=null;
            age = 90;
            if (age.HasValue)
            {
                Console.WriteLine($"Age is {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is Unknown.");
            }
            //assing nullabe value to non nullable type

            // int displayAge = age; //compilation error
            //use null-coalescing operation:
            int displayedAge = age ?? 10;
            Console.WriteLine(displayedAge);

        }
    }
}
