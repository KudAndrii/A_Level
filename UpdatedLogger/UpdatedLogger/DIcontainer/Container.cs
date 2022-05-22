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

namespace UpdatedLogger.DIcontainer
{
    internal class Container
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IFileService, FileService>()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IStarter, Starter>()
                .AddTransient<IActions, Actions>()
                .AddTransient<Random>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
