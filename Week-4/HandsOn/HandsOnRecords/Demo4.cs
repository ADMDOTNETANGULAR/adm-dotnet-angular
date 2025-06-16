using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnRecords
{
    //primary constructors for non-record stucts
    public struct Point(int x, int y)
    {
        public int X => x;
        public int Y => y;
    }
    internal class Demo4
    {
    }
}
