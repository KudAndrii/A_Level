using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDb.IoC
{
    using Microsoft.Extensions.DependencyInjection;
    using LazyLoadingDb.DatabaseContext;
    using LazyLoadingDb.Interfaces;
    internal class Container
    {
        public ServiceProvider Load()
        {
            var result = new ServiceCollection()
                .AddTransient<IRequestList, RequestList>()
                .AddSingleton<FirstDatabaseContext>()
                .BuildServiceProvider();

            return result;
        }
    }
}
