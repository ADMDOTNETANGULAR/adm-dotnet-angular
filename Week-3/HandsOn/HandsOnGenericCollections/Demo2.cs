using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    public interface ITest<T>
    {
        T M1();
        T M2(T a);
    }
    internal class Demo2 : ITest<int>
    {
        public int M1()
        {
            throw new NotImplementedException();
        }

        public int M2(int a)
        {
            throw new NotImplementedException();
        }
    }
}
