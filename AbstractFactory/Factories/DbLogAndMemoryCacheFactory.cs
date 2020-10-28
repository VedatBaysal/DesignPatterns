using AbstractFactory.Interfaces;
using AbstractFactory.Services.Caching;
using AbstractFactory.Services.Loggers;

namespace AbstractFactory.Factories
{
    class DbLogAndMemoryCacheFactory : ICrossCuttingConcernsFactory
    {
        public ICache CreateCaching()
        {
            return new MemoryCache();
        }

        public ILogger CreateLogger()
        {
            return new DbLogger();
        }
    }
}
