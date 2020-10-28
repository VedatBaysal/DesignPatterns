using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Services.Loggers
{
    class DbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged From Db");
        }
    }
}
