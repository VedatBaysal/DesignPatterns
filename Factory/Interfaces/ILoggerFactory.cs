using Factory.Services;

namespace Factory
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(LoggerType log);
    }
}