using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoPark.Interfaces;
using AutoPark.Models.Factorys;

namespace AutoPark.Services
{
    internal class Container
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IGarageService, GarageService>()
                .AddTransient<IMachineCountService, MachineCountService>()
                .AddTransient<IEngineFactory, EngineFactory>()
                .AddTransient<Random>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
