using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexes
{
    internal class Demo1
    {
        private int[] a = new int[3];
      
        //define indexer
        public int this[int x]
        {
            get { return a[x]; } //get value from array
            set
            {
                if (x <= a.Length - 1)
                {
                    a[x] = value;
                    b[x] = value;
                }
                else
                {
                    Console.WriteLine("Size exceed!!");
                } //set value to the array
            }

        }
        static void Main()
        {
            Demo1 demo = new Demo1();
            demo[0] = 12; //indexer set access invoke
            demo[1] = 13;
            demo[2] = 14;
            demo[20] = 3409;
            Console.WriteLine(demo[0]); //indexers get accesser invoke
            Console.WriteLine(demo[1]);
            Console.WriteLine(demo[2]);

        }
    }
}
