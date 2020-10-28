using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Database Logger And Memory Caching!");
            var factory = new DbLogAndMemoryCacheFactory();
            ICache caching =  factory.CreateCaching();
            ILogger Logger = factory.CreateLogger();
            caching.Cache();
            Logger.Log();
            Console.ReadKey();
        }
    }
}
