using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo1
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a, b values for division:");
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                if(b==0)
                {
                    throw new DivideByZeroException("b cannot be zero for division.");
                }
                int c = a / b;
                Console.WriteLine($"Result: {c}");
                Console.WriteLine("This line will not be executed if an exception occurs above.");
            }
            catch (DivideByZeroException ex)
            {
                //catch block to handle DivideByZeroException
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Value should between 0 and 255 for byte type.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (Exception ex) //define catch block for general exceptions
            {
                //catch block to handle any other exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
        }
    }
}
