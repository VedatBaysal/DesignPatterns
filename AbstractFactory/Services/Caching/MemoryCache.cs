using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.Caching
{
    class MemoryCache : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Caching From MemoryCache");
        }
    }
}
