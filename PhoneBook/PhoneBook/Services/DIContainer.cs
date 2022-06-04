using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneBook.Services
{
    internal class DIContainer
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Random>()
                .AddTransient<>
        }
    }
}
