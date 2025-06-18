using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Microsoft.VisualBasic;
namespace HandsOnJsonSerialization
{
    internal class Demo1
    {
        static void Main()
        {
            var people = new List<Person>
            {
                new Person("Navya",12),
                new Person("Tina",10)
            };
            string jsonList=JsonSerializer.Serialize(people,new JsonSerializerOptions()
            {
                WriteIndented = true
            });
            Console.WriteLine(jsonList);
          using(FileStream fs=new FileStream("D:\\CTS\\Batch-Angular\\Week-4\\person.json", FileMode.Create,FileAccess.Write))
            {
                byte[] data = new UTF8Encoding().GetBytes(jsonList);
                fs.Write(data, 0, data.Length);
            }
        }
    }
}
