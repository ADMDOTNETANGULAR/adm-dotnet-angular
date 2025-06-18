using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileOperations
{
    internal class Demo1
    {
        //reading and writing using bytes
        static void Read(string path)
        {
            using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                byte[] content = new byte[fs.Length];
                fs.Read(content, 0, content.Length); //reading 5 chars from the given file starting from 0 position
                foreach (var item in content)
                {
                    Console.WriteLine(item);
                }
                //convert byte array to string
                string data=new UTF8Encoding().GetString(content);
                Console.WriteLine(data);


            }
        }
        static void Write(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string content = "C# is a Object Programming Language!!";
                    byte[] data = new UTF8Encoding().GetBytes(content); //converts string data to bytes
                   fs.Seek(0,SeekOrigin.End); //to set the position in the given file.
                    fs.Write(data, 0, data.Length);
                }
            }
            catch (IOException)
            {

                throw;
            }
        }
        static void Main()
        {
            try
            {
                //Read(@"D:\\CTS\\Batch-Angular\\Week-4\1.txt");
                Write(@"D:\\CTS\\Batch-Angular\\Week-4\3.txt");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
