using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Customer
    {
        //define fields
        private int id; //private field, accessible only within the class
        public string name; //public field, accessible from outside the class
        protected string email; //protected field, accessible within the class and derived classes
        internal string address; //internal field, accessible within the same assembly
        public void Details() //public method to display customer details
        {
            Console.WriteLine($"Customer ID: {id}, Name: {name}, Email: {email}, Address: {address}");
        }
    }
    class Test_Customer
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Customer class
            Customer customer = new Customer();
            // Initializing the public field
            customer.name = "Alice";
            customer.address = "123 Main St"; // This is allowed because 'address' is internal
            // Accessing the public field
            Console.WriteLine($"Customer Name: {customer.name}"); // Output: Customer Name: Alice
            Console.WriteLine($"Customer Address: {customer.address}"); // Output: Customer Address: 123 Main St

            // The following lines would cause errors because of access modifiers
           // Console.WriteLine(customer.id); // Error: 'Customer.id' is inaccessible due to its protection level
            //Console.WriteLine(customer.email); // Error: 'Customer.email' is inaccessible due to its protection level
          
        }
    }
}
