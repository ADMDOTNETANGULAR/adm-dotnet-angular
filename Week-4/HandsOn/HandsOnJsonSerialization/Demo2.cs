using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace HandsOnJsonSerialization
{
    class Employee
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        [JsonIgnore] //Salary can not be Serialize
        public double Salary { get; set; }
    }
    internal class Demo2
    {
        static void Main()
        {
            var employee = new Employee() { Id = 3983, Name = "Sandeep", Salary = 50000 };
            var jsonstring=JsonSerializer.Serialize(employee);
            Console.WriteLine(jsonstring);
        }
    }
}
