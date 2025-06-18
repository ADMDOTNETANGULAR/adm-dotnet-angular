using System.Net.Http.Headers;

namespace HandsOnDelegates
{
    //delegate declartion
    public delegate void MyDelegate();
    public delegate void GreetDelegate(string name);
    internal class Program
    {
        public void M1()
        {
            Console.WriteLine("I am Invoking by Delegate");
        }
        public void Greet(string name) => Console.WriteLine("Hello " + name);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            //delegate instantiate
            MyDelegate obj = new MyDelegate(program.M1); //assign M1 reference to Delegate
            //invoke delete
            obj();//M1() is invoking which is refered by MyDelete
            GreetDelegate obj1=program.Greet;
            //invoking delegate
            obj1("Sachin");
        }
    }
}
