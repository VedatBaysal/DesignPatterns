using AbstractFactory.Interfaces;

namespace AbstractFactory.Services.Loggers
{
    public class VBLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged from VBLogger");
        }
    }
}
