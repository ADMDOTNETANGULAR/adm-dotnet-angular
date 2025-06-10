namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Person class
            Person person = new Person("John Doe", 30); // Using the constructor to initialize the object
            //call the method to display the person's details
            person.DisplayDetails(); // Output: Name: John Doe, Age: 30
            // Using the property to get and set the name
            person.Name = "Bob";
            person.DisplayDetails(); // Output: Name: Bob, Age: 30
        }
    }
}
