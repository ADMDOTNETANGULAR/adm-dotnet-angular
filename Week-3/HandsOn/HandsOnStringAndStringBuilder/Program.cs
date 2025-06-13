using System.Text;
namespace HandsOnStringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings are immutable
            string s = "Hello World";
            s.Replace("World", "C#");
            Console.WriteLine(s);
            //mutable strings
            StringBuilder stringBuilder = new StringBuilder();
            //assign value
            stringBuilder.Append("Hello World");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Replace("World", "C#");
            Console.WriteLine(stringBuilder);

            
        }
    }
}
