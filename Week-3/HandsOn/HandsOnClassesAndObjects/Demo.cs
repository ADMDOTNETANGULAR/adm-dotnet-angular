using HandsOnClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects_Demo
{
    internal class Demo
    {
        static void Main()
        {
            Customer customer = new Customer();
            customer.address = "123 Main St"; // This is allowed because 'address' is internal
        }
    }
}
