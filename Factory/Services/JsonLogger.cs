using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class JsonLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged From JsonLogger");
        }
    }
}
