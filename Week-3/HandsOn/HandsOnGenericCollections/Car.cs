using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Car
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Id:{ModelId} Name:{ModelName} Price:{Price}";
        }
    }
}
