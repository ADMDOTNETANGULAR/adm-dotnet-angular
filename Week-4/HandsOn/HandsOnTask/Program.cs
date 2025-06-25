using System.Threading.Tasks;
namespace HandsOnTask
{
    internal class Program
    {
        public void Operation()
        {
            for(int i=0;i<10;i++)
            {
                Task.Delay(1000).Wait(); // Simulating some work //This is a blocking call. It blocks the current thread. Better use await Task.Delay() for non-blocking code.
                Console.WriteLine($"Operation {i + 1} completed.");
            }
        }
        static void Main(string[] args)
        {
            //Initiating task
            Program program = new Program();
            Task task=Task.Run(()=> program.Operation()); //Runs Operation in the thread pool (parallel to main thread).
            //Waiting for task to complete
          task.Wait(); //Blocks Main method until the task is finished.
            Console.WriteLine("Task Finished");
        }
    }
}
