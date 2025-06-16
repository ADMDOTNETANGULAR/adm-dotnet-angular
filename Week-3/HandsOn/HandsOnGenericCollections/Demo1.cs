using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    public class KeyPair<K,V>
    {
        public K i;
        public V j;
    }
    internal class Demo1
    {
        static void Main()
        {
            KeyPair<int,char> obj = new KeyPair<int,char>();
            obj.i = 1;
            obj.j = 'A';
        }
    }
}
