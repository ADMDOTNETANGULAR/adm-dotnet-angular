using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Class1
    {
        public List<int> Ids=new List<int>();
        static void Main()
        {
            Class1 obj = new Class1();
            obj.Ids.Add(10); obj.Ids.Add(20);

        }
    }
}
