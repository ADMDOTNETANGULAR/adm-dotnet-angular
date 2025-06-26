using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFUsingCodeFirst.Entities
{
    internal class Product
    {
        public int Id { get; set; } //set as primary key column with auto-increment
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
