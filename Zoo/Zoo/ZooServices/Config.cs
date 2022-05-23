using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Zoo
{
    internal class Config
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IZooServices, ZooServices>()
                .AddTransient<Random>().BuildServiceProvider();
            return serviceProvider;
        }
    }
}
