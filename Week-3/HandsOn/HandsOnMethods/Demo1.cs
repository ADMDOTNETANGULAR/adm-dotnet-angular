using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    //local methods
    //Local methods are methods that are defined within the scope of another method.
    //They can be used to encapsulate logic that is only relevant to that specific method, improving code organization and readability.
    //Not available in C# 11, but available in C# 12.
    //Not visible outside the method they are defined in, which helps to keep the code clean and avoids polluting the outer scope with unnecessary methods.
    internal class Demo1
    {
        public int Number = 10;
        public void OuterMethod()
        {
            Console.WriteLine("Outer method called.");
            // Local method defined within the outer method
            void InnerMethod()
            {
                Number += 5; // Accessing the outer method's variable
                Console.WriteLine("Inner method called.");
            }
            // Call the local method
            InnerMethod();
        }
        public void RegisterUser(string name, string pwd)
        {
            if (ValidateCredentials(name, pwd))
            {
                Console.WriteLine("User registered successfully.");
            }
            else
            {
                Console.WriteLine("Invalid credentials provided.");
            }
            //Local method to validate user credentials
            bool ValidateCredentials(string username, string password)
            {
                // Simple validation logic (for demonstration purposes)
                return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
            }
           
        }
        static void Main()
        {
            Demo1 demo = new Demo1();
            demo.OuterMethod(); // Calling the outer method which in turn calls the inner method
            demo.RegisterUser("John", "password123"); // Calling the method to register a user with local validation logic
            demo.RegisterUser("", ""); // Calling the method with invalid credentials to demonstrate local method validation
        }
    }
}
