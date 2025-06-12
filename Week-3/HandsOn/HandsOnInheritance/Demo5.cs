using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance_1
{
    class Animal
    {
        public virtual void Sound()=> Console.WriteLine("Animal makes a sound");
    }
    class  Dog:Animal
    {
        public override void Sound() => Console.WriteLine("Dog barks");
        public void F()
        {
            Sound(); // Calls the overridden method in Dog class
            base.Sound(); // Calls the base class method
        }
        
    }
    internal class Demo5
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Sound(); // Output: Dog barks // Calls the overridden method in Dog class
            Animal animal = new Dog(); // Upcasting: Dog is treated as an Animal
            //access all the members of Animal class
            animal.Sound(); // Output: Dog barks // Calls the overridden method in Dog class due to polymorphism
            Animal animal2 = new Animal();
            animal2.Sound(); // Output: Animal makes a sound // Calls the base class method
        }
    }
}
