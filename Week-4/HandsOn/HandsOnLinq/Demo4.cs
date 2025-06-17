using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo4
    {
        static void Main()
        {
            //Query data using method syntax
            int[] numbers = { 12, 23, 34, 45, 56, 76, 67, 78, 12, 89, 90, 98, 87, 76, 65, 54, 43, 32, 21 };
            var result = numbers.Where(x => x > 50); //return values >50
             result = numbers.Where(x => x > 50 && x % 2 == 0); //return values > 50 and even
            result=numbers.Where(x=>x>50).OrderBy(x=>x);
            result = numbers.Where(x => x % 2 == 0).OrderByDescending(x => x);
            result = numbers.Where(x => x > 50).Distinct();
            List<int> ints = numbers.Where(x => x > 50).ToList();
            int[] arry = numbers.Where(x => x > 50).ToArray();
            int count = numbers.Where(x => x > 50).Count();
            int max = numbers.Where(x => x > 50).Max();
            int min = numbers.Where(x => x > 50).Min();
            int sum = numbers.Where(x => x > 50).Sum();
        }
    }
}
