using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStructsAndEnums
{
    // an enum is a value type that defines a set of named constants
    // it is used to represent a collection of related constants
    //like a set of options or states or categories or days of the week,roles, etc.
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday=32,
        Thursday,
        Friday,
        Saturday
    }
    public enum Roles: byte // byte is used to save memory, as enum values are small integers
    {
        Admin=1,
        User=2,
        Guest=3
    }
    public enum Status
    {
        Active=1,
        Inactive=3,
        Pending=6
    }
    internal class Demo2
    {
      static void Main()
        {
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine($"Numeric value of {today} is: {(int)today}");
            Console.WriteLine($"Numeric value of {DaysOfWeek.Sunday} is: {(int)DaysOfWeek.Sunday}");
        }
    }
}
