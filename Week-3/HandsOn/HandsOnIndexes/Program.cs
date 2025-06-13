namespace HandsOnIndexes
{
    //Indexes are use to make use the class object as an array type at runtime
    class Sample
    {
        private int x;
        public int[] a = new int[3];

        public int X { get => x; set => x = value; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.X = 10; //set value to private variable x
            sample.a[10] = 1; //runtime error
            string s = "Hello World";
            Console.WriteLine(s[1]);
           
        }
    }
}
