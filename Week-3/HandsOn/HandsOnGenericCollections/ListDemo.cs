using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class ListDemo
    {
        static void Main()
        {
            //collectioin initializer
            List<int> list = new List<int>() { 12, 23, 34, 45, 56, 67, 78 };
            List<string> flowers = new List<string>(); //empty list
            //add items to list
            flowers.Add("Rose");
            flowers.Add("Lilly");
            flowers.Insert(1, "Tulips"); //add items using index
            flowers.Add("Jasmine");
            //size of the List
            Console.WriteLine("Flowers in the list: "+flowers.Count);
            //access item
            string flower = flowers[2]; //Lilly
            //fetch all itesm
            foreach(var k in flowers)
                Console.WriteLine(k);
            //remove item
            flowers.Remove(flower);
            flowers.RemoveAt(1);
            flowers.Sort(); //sort items
            flowers.Reverse(); //reverse items


        }
    }
}
