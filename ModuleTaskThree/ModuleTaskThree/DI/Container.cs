using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ModuleTaskThree.Abstractions;
using ModuleTaskThree.Services;

namespace ModuleTaskThree.DI
{
    public class Container
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfigService, ConfigService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
