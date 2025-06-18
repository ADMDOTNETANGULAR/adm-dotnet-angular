using System.IO;
namespace HandsOnFileOperations
{
    internal class Program
    {
        static void Read(string path)
        {
            try
            {
                StreamReader streamReader = new StreamReader(path);
                string content = streamReader.ReadToEnd(); //Read the file
                Console.WriteLine(content);
            }
            catch (IOException)
            {

                throw;
            }
        }
        static void Write(string path)
        {
            try
            {
                string content = "All glitters are not Gold!!!";
                //string content = "Good Morning Users";
                //using block automaticly close/dispose the objects
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    streamWriter.WriteLine(content); //content added to file

                }
            }
            catch (IOException)
            {

                throw;
            }
        }
        static void WriteObjets(string path)
        {
            try
            {
                List<Student> students = new List<Student>()
                {
                    new Student(){Id=1,Name="Ram",Age=10},
                     new Student(){Id=2,Name="Tina",Age=11},
                      new Student(){Id=3,Name="Raj",Age=12},
                };
                foreach (var item in students)
                {
                    using (StreamWriter streamWriter = new StreamWriter(path, true))
                    {
                        streamWriter.WriteLine(item); //content added to file

                    }
                }
                
            }
            catch (IOException)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter File Path");
                string path = Console.ReadLine();
                //Read(@"D:\CTS\Batch-Angular\Week-3\Collections1.txt");
                //Read(path);
                //Write(path);
                WriteObjets(path);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
