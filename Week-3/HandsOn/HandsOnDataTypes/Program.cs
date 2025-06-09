namespace HandsOnDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //working with variables
            //Premitive data types in C#(fixed size data types)
            //Value types(stored in stack memory)
            //numeric data types
            int age = 30; // integer variable
            double salary = 50000.50; // double variable
            float height = 5.9f; // float variable
            decimal price = 19.99m; // decimal variable
            long population = 7800000000L; // long variable
            short temperature = -5; // short variable
            byte level = 255; // byte variable
            sbyte balance = -128; // sbyte variable
            uint positiveNumber = 4000000000U; // unsigned integer variable
            ulong largeNumber = 18446744073709551615UL; // unsigned long variable
            ushort ushortValue = 65000; // unsigned short variable
            //char data type
            char initial = 'A'; // char variable
            //boolean data type
            bool isActive = true; // boolean variable
            //Reference types(stored in heap memory)
            //string data type
            string name = "John Doe"; // string variable
            //object data type
            object obj = "This is an object"; // object variable
            obj = 342;
            //int k = obj; //results in compile-time error, cannot implicitly convert object to int
            Console.WriteLine(obj.GetType()); // prints the type of obj
            object o1= 100; // object variable holding an integer
            object o2 = 3.14; // object variable holding a double
            object o3 = 'A'; // object variable holding a char
            object o4 = true; // object variable holding a boolean
            //other data types in C#
            //dynamic data type(allows changing type at runtime)
            dynamic dynValue = "I am dynamic"; // dynamic variable
            dynValue = 42; // changing the type at runtime
            int i= dynValue; // assigning dynamic to int
            dynValue = 3.14; // changing the type again
            double d = dynValue; // assigning dynamic to double
            //var data type
            var v1 = "I am a var type"; // var variable, type inferred at compile time
            v1= "Now I am still a string"; // still a string
            var v2 = 100; // var variable, type inferred as int
            var v3 = 3.14; // var variable, type inferred as double
            var v4 = true;
        }
    }
}
