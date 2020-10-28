using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Services.Caching
{
    class ObjectCache : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Caching From ObjectCache");
        }
    }
}
