using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Services
{
    class DbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged From Db");
        }
    }
}
