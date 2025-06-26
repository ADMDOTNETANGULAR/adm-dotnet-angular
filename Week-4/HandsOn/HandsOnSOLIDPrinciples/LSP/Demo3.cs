using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.LSP
{
    public abstract class Bird
    {
        public abstract void Eat();
    }
    public abstract class FlyingBird : Bird
    {
        public abstract void Fly();
    }
    public class Sparrow : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Sparrow is eating seeds.");
        }
        public override void Fly()=>Console.WriteLine("Sparrow is flying.");

    }
    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich is eating plants.");
        }
    }
    internal class Demo3
    {
    }
}
