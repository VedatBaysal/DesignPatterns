using Factory.Services;

namespace Factory
{
    public class LoggerFactory: ILoggerFactory
    {
        public ILogger CreateLogger(LoggerType log)
        {
            return log switch
            {
                LoggerType.DatabaseLogger => new DbLogger(),
                LoggerType.JsonLogger => new JsonLogger(),
                LoggerType.VBLogger => new VBLogger(),
                _ => throw new System.NotImplementedException()
            };
        }
    }
}
