namespace HandsOnMethods
{
    //A method is a block of code that performs a specific task.
    // A method is defined by a name, a return type, and a set of parameters.
    //A method can be called by its name, and it can return a value or perform an action.
    // Can return a value or be void (no return value).
    public class  Calculator
    {
        public void Message()
        {
            //write code here
         Console.WriteLine("Hello, this is a method in C#.");
        }
        public int Add(int a, int b)
        {
            int c = a + b; //here c is the local variable
            // This method adds two integers and returns the result.
            return c; // Return the sum of a and b
        }
    }
    internal class Program
    {
        //Debugging is the process of finding and fixing errors in code.
        //Excution the code line by line to find errors.
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            // Call the method to display the message
            calculator.Message();
            var result=calculator.Add(4, 5);
            Console.WriteLine($"The sum of 4 and 5 is: {result}");
        }
    }
}
