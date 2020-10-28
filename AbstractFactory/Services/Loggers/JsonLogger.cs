using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Services.Loggers
{
    class JsonLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged From JsonLogger");
        }
    }
}
