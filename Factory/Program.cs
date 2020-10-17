using Factory.Services;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            loggerFactory.CreateLogger(LoggerType.DatabaseLogger).Log();
            Console.ReadKey();
        }
    }
}
