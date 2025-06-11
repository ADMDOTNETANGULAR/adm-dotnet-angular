namespace HandsOnInheritance
{
    //Inhertiance is an object-oriented programming concept
    //that allows a class to inherit members (fields, methods, properties, etc.) from another class.
    //This promotes code reuse and establishes a relationship between classes.
    //In C#, inheritance is implemented using the `:` symbol.
    //The class that inherits is called the derived class, and the class being inherited from is called the base class.
    public class Animal //base class
    {
        public void Eat() => Console.WriteLine("Animal is eating");
    }
    public class Dog : Animal //derived class
    {
        public void Bark() => Console.WriteLine("Dog is barking");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog mydog= new Dog(); //creating an instance of the derived class
            mydog.Eat(); //calling a method from the base class //inherited method
            mydog.Bark();//calling a method from the derived class //own method

        }
    }
}
