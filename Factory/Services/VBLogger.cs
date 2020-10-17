namespace Factory
{
    public class VBLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged from VBLogger");
        }
    }
}
