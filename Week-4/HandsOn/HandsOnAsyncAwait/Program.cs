namespace HandsOnAsyncAwait
{
    internal class Program
    {
        // This method is not async
        public static void M1()
        {
            Console.WriteLine("M1 Stared");
            Thread.Sleep(1000); // This will block the current thread for 1 second
            Console.WriteLine("M1 Completed");

        }
        // This method is async
        public static async void M2()
        {
            Console.WriteLine("M2 Stared");
            await Task.Delay(5000);  /*
             Task.Dealy() executed, it will free the current thread, and then that 
            current thread comes and execute the rest of the code inside the main method. 
            And after 5 seconds again thread come back to the
            Method2 and execute the rest of the code inside the Method2.
             */
            Console.WriteLine("M2 Completed");
        }
        public static void Greet()
        {
                       Console.WriteLine("Hello from the  method!");
        }
        static void Main(string[] args)
        {
           //M1();
            M2();
            Greet();
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}
