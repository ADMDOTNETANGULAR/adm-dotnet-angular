using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFileOperations
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Age:{Age}";
        }
    }
}
