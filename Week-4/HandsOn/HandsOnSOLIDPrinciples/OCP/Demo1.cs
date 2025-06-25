using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.OCP
{
    public class Logger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public virtual void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }
    public class NewLogger : Logger
    {
        public override void Debug(string message)
        {
            Console.WriteLine($"Dev Debug -> {message}");
        }
    }
    internal class Demo1
    {
        public static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Debug("Testing debug");

            Logger newlogger = new NewLogger();
            newlogger.Debug("Testing debug ");
        }
    }
}
