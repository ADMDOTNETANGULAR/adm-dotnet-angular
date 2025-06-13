namespace HandsOnRegularExpressions
{
    //In C# Regular Expreeesions(Regex) are used to search,match,manipulate strings based on
    //specific pattern. use the System.Text.RegularExpressions namespace to work with them
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User obj= new User();
            obj.Email = "fdsljfdsl";
            obj.Mobile = "AFSofds";
        }
    }
}
