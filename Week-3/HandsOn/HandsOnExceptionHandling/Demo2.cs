using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Sample
    {
        public void M1() { }
    }
    internal class Demo2
    {
        static void Main()
        {
           try
            {
                Sample s = null;
                if(s == null)
                {
                    throw new NullReferenceException("Sample object is null, cannot access its members.");
                }
                s.M1(); // This will throw a NullReferenceException
            }
            catch(NullReferenceException ex)
            {
                //catch block to handle NullReferenceException
                Console.WriteLine("Error: Attempted to access a member on a null object reference.");
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
