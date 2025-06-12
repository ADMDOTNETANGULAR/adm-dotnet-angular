using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    public class Compute
    {
        public int Divide(byte a, byte b)
        {
            try
            {
                int c = a / b;
                Sample sample = null;
                sample.M1(); // This will throw a NullReferenceException
                return c;
            }
            catch (DivideByZeroException ex)
            {
                //catch block to handle DivideByZeroException
              //  Console.WriteLine("Error: Division by zero is not allowed.");
                //Console.WriteLine($"Exception Message: {ex.Message}");
                throw; // rethrowing the exception to be handled by the caller
            }
        }
    }
    internal class Demo3
    {
        static void Main()
        {
           try
            {
                Compute obj = new Compute();
                Console.WriteLine(obj.Divide(10, 2)); // This will throw a DivideByZeroException
            }
            catch(Exception ex) //define catch block for general exceptions
            {
                //catch block to handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed, whether an exception occurred or not.");
            }
        }
    }
}
