using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class DictionaryDemo
    {
        static void Main()
        {
            //stored multiple key-value pairs
            Dictionary<int,string> obj = new Dictionary<int,string>();
            //add items
            obj.Add(4303, "Ram");
            obj.Add(1234, "Kavya");
            obj.Add(3233, "Tina");
            //access value
            string name = obj[3233]; //return value of 3233
            //remove key
            obj.Remove(1234); //remove the key-value pair
            //access all the key value pairs
            foreach(int key in obj.Keys)
            {
                Console.WriteLine($"Key:{key} Value:{obj[key]}");
            }
            foreach(KeyValuePair<int,string> pair in obj)
            {
                Console.WriteLine($"Key:{pair.Key} Value:{pair.Value}");
            }
            Dictionary<int,Student> keyValuePairs = new Dictionary<int,Student>();
            keyValuePairs.Add(1, new Student() { Id = 1, Name = "Kavya", Age = 12 });
        }
    }
}
