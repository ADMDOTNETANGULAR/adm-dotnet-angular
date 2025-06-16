using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnRecords
{
    //primary constructors for non-record classes
    public class Customer(string name,int age)
    {
        public string Name => name;
        public int Age => age;
        public void PrintInfo() => Console.WriteLine($"Name:{name} Age:{age}");
    }
    internal class Demo3
    {
        static void Main()
        {
            var customer = new Customer("Virat",36);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Age);
            customer.PrintInfo();
            
        }
    }
}
