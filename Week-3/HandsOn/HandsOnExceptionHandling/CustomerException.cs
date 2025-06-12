using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    //custom exception class
    class TickeException:SystemException
    {
        string message;
        public TickeException(string message)
        {
            this.message = message;
        }
        public override string Message => message;
    }
    class BookTicket
    {
        public void Book()
        {
            try
            {
                Console.WriteLine("Enter the No of Tickers to Book");
                int count = int.Parse(Console.ReadLine());
                if (count > 4)
                {
                    throw new TickeException("Transaction Faild User is trying to book more than 3 tickets");
                }
                else
                {
                    Console.WriteLine("Transaction Completed Successfully!!");
                }
            }
            catch (TickeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
    internal class CustomerException
    {
        static void Main()
        {
           try
            {
                BookTicket bookTicket = new BookTicket();
                bookTicket.Book();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
