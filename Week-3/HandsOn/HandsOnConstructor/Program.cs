namespace HandsOnConstructor
{
    class Sample
    {
        //define constructor
        public Sample() //default constructor
        {
            Console.WriteLine("Constuctor called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
        }
    }
}
