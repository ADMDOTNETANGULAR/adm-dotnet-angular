namespace HandsOnMultiThreading
{
    internal class Program
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number {i} from thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(500); // Wait 0.5 seconds
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(PrintNumbers);
            t.Start(); //start the new thrad
            Console.WriteLine("Main thread starts...");
        }
    }
}
