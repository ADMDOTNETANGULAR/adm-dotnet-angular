using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNullableTypes
{
    internal class User
    {
        public string? MiddleName { get; set; }
        public int? Age { get; set; }
        static void Main()
        {
            var user = new User();
            Console.WriteLine(user.MiddleName??"No MiddleName");
            Console.WriteLine(user.Age ?.ToString()?? "Age is not Provided");
            // int?
            // ??,?.
        }
    }
}
