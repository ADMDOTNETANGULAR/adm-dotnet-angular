namespace HandsOnGenericCollections
{
    //class Sample
    //{
    //    public int i;
    //    public char j;
    //}
    //Generic class
    class Sample<T>
    {
        //Generic variables
        public T i;
        public T j;
        public int k; //k type is same for all the objects
        public void Accept(T m,T n)
        {
            i=m; j = n;
        }
        public void Display()
        {
            Console.WriteLine($"i={i} j={j}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample s1=new Sample() { i = 1,j='a' };
            //Sample s2 = new Sample() { i = 2, j = 'b' };
            //Generic object
            Sample<int> s1 = new Sample<int>();
            s1.i = 1;
            s1.j = 2;
            s1.Accept(2, 3);
            Sample<string> s2 = new Sample<string>();
            s2.i = "A";
            s2.j = "B";
            Sample<char> s3 = new Sample<char>();
            s3.i = 'i';
            s3.j = 'j';
            
        }
    }
}
