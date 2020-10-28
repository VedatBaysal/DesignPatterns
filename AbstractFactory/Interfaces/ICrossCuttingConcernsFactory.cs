using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    interface ICrossCuttingConcernsFactory
    {
        ICache CreateCaching();
        ILogger CreateLogger();
    }
}
