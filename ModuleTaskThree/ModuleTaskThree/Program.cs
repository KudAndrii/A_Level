using System;
using ModuleTaskThree.DI;
using Microsoft.Extensions.DependencyInjection;
using ModuleTaskThree.Abstractions;
using ModuleTaskThree.Models;

namespace ModuleTaskThree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var configService = new Container().Load().GetService<IConfigService>();
            var starter = new Starter();
            var logGenerator = new LogGenerator();
        }
    }
}
