using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Customer
    {
        public int id;
        public string name;
        //default constructor
        public Customer()
        {
            id=345;
            name = "Rajan";
        }
        //parameterized constructor
        public Customer(int customerid,string customername)
        {
            id = customerid;
            name = customername;
        }
        public void display()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
    internal class Demo1
    {
        static void Main()
        {

            Customer c1=new Customer() { id = 101, name = "John" };
            c1.display();
            Customer c2 = new Customer();
            c2.display();
            Customer c3 = new Customer();
            c3.display();
            Customer c4 = new Customer(110, "Krishnan");
            c4.display();
            Customer c5= new Customer(120, "Ravi");
            c5.display();
        }
    }
}
