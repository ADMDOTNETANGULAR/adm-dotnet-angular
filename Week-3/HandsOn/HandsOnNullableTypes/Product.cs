using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNullableTypes
{
    internal class Product
    {
        //Nullable properties
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        static void Main()
        {
            Product obj=new Product() { Id = 1 };
            Console.WriteLine("Id "+obj.Id);
            Console.WriteLine("Name "+obj.Name);
            Console.WriteLine("Price "+obj.Price);
            Console.WriteLine("Stock "+obj.Stock);
            //Null-Coalescing Operator
            string? input = null;
            string result = input??"Default";
            string? name = null;
            //null-conditional operation ?
            int? length = name?.Length; //safe access, retruns null if name is null
        }
    }
}
