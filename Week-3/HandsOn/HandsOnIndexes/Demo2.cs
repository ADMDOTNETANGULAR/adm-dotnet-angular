using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexes
{
    internal class Demo2
    {
        int[,] a = new int[2, 2];
        string[] flowers = new string[3];
        //define indexer with 2 parameters
        public int this[int x, int y]
        {
            get { return a[x, y]; }
            set { a[x, y] = value; }
        }
        public string this[int x]
        {
            get { return flowers[x]; }
            set { flowers[x] = value; }
        }
        static void Main()
        {
            Demo2 demo = new Demo2();
            demo[1] = "Rose"; //invoke 1 dimensional array
            demo[0, 0] = 10; //invoke 2 dimensional array
        }
    }
}
