using System;
using UpdatedLogger.Interfaces;
using UpdatedLogger.DIcontainer;
using Microsoft.Extensions.DependencyInjection;

namespace UpdatedLogger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var starter = new Container().Load().GetService<IStarter>();
            starter.Run();
        }
    }
}
