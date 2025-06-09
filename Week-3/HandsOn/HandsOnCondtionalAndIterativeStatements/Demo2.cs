using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCondtionalAndIterativeStatements
{
    internal class Demo2
    {
        static void Main()
        {
            //Switch statement
            int day = 13;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
            //swith statement with grouped cases
            int month = 2;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days in this month.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days in this month.");
                    break;
                case 2:
                    Console.WriteLine("28 or 29 days in this month.");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }
        }
    }
}