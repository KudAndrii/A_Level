using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.IoC_container
{
    using Microsoft.Extensions.DependencyInjection;
    using ReqresRequests.Interfaces;
    public class Container
    {
        public ServiceProvider Load()
        {
            var result = new ServiceCollection()
                .AddTransient<HttpClient>()
                .AddTransient<IReqresClient, ReqresClient>()
                .BuildServiceProvider();

            return result;
        }
    }
}
