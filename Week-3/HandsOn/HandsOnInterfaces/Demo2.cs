using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
    public class Laptop : IProduct
    {
        //implementing the IProduct interface members
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Laptop(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
    internal class Demo2
    {
    }
}
