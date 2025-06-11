using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    //Automatic properties are a shorthand syntax for defining properties without explicitly declaring a backing field.
    //They are useful when you don't need to add any additional logic in the get or set accessors.
    //Automatic properties are used in databinding scenarios, where you want to bind data to UI controls without writing extra code.
    class Product
    {
        //Automatic properties for Id,Name and Price
        public int Id { get; set; } //Automatic property for Id
        public string Name { get; set; } //Automatic property for Name
        public decimal Price { get; set; } //Automatic property for Price
    }
    internal class Demo4
    {
        static void Main()
        {  Product p1 = new Product(); //Creating an instance of Product
            p1.Id = 1; //Setting Id using automatic property
            p1.Name = "Laptop"; //Setting Name using automatic property
            p1.Price = 999.99m; //Setting Price using automatic property
            //Displaying the product details
            Console.WriteLine($"Product Id: {p1.Id}");
            Console.WriteLine($"Product Name: {p1.Name}");
            Console.WriteLine($"Product Price: {p1.Price:C}"); //C format specifier for currency
        }
    }
}
