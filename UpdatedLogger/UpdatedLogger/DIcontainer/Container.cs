using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using UpdatedLogger.FileServices;
using UpdatedLogger.Interfaces;
using UpdatedLogger.AppPricessing;
using UpdatedLogger.Configs;
using UpdatedLogger.Logger;

namespace UpdatedLogger.DIcontainer
{
    internal class Container
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMyLogger, MyLogger>()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IStarter, Starter>()
                .AddTransient<IActions, Actions>()
                .AddTransient<Random>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
