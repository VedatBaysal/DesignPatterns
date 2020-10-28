using AbstractFactory.Interfaces;
using AbstractFactory.Services.Caching;
using AbstractFactory.Services.Loggers;

namespace AbstractFactory.Factories
{
    class JsonLogAndObjectCacheFactory : ICrossCuttingConcernsFactory
    {
        public ICache CreateCaching()
        {
            return new ObjectCache();
        }

        public ILogger CreateLogger()
        {
            return new JsonLogger();
        }
    }
}
