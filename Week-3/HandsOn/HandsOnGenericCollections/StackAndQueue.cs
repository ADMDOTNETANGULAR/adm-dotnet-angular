using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class StackAndQueue
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            //fetch item
            int k = stack.Peek(); //returns top value
            stack.Pop(); //top value remvoe
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Queue<string> queue = new Queue<string>();
            //add items
            queue.Enqueue("Rose");
            queue.Enqueue("Lilly");
            queue.Enqueue("Tulips");
            queue.Enqueue("Jasmine");
            //fetech items
            string s = queue.Peek(); //return first item
            //remove item
            queue.Dequeue(); //remove first item
            //fetch all items
            foreach(var item in queue)
                { Console.WriteLine(item); }


        }
    }
}
