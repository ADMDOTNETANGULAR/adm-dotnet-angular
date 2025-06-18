using System.Text.Json; //.Net Core 3.0
namespace HandsOnJsonSerialization
{
    public record Person(string Name, int Age);
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Serialization(Convert objects to Jsonstring)
            var person = new Person("Virat", 35);
            string jsonString=JsonSerializer.Serialize(person);
            Console.WriteLine(jsonString);
            //DeSerilizaation(Convert Json string to Object)
            var obj=JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(obj);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true, //pretty pint
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
               
            };
            jsonString = JsonSerializer.Serialize(person,options);
            Console.WriteLine(jsonString);

        }
    }
}
