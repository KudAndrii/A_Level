using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using FirstDatabase.Interfaces;
using FirstDatabase.Services;

namespace FirstDatabase.Services
{
    internal class Container
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfigService, ConfigService>()
                .AddSingleton<Context>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
