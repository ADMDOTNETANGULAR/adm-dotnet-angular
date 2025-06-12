namespace HandsOnInterfaces
{
    public interface IEmployee
    {
        //abstract members
        void Work();
        string GetName();
    }
    public class  Developer:IEmployee
    {
        public void Work()
        {
            Console.WriteLine("Developing the application");
        }
        public string GetName()
        {
            return "Developed Employee";
        }
        public void Role()
        {
            Console.WriteLine("Role of Developer is to write code");
        }
    }
    public class Tester : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("Testing the application");
        }
        public string GetName()
        {
            return "Tester Employee";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee developer = new Developer();
            //access only the members of IEmployee interface in developer reference
            developer.Work();
            Console.WriteLine(developer.GetName());
            //developer.Role(); // This will cause a compile-time error because Role is not part of IEmployee interface
            // To access Role, we need to cast developer to Developer type
            Developer dev = new Developer();
            dev.Role(); // Now we can access Role method
            dev.Work(); // Still can access Work method from IEmployee interface
            Console.WriteLine(dev.GetName()); // Still can access GetName method from IEmployee interface
            IEmployee tester = new Tester();
            tester.Work(); // Calls the Work method from Tester class
            Console.WriteLine(tester.GetName()); // Calls the GetName method from Tester class
        }
    }
}
