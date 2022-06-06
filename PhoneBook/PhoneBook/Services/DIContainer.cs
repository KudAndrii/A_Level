using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Interfaces;
using PhoneBook.Services;

namespace PhoneBook.Services
{
    internal class DIContainer
    {
        public ServiceProvider Load()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Run>()
                .AddTransient<Random>()
                .AddTransient<JSConfig>()
                .AddTransient<IContactsServices, ContactsServices>()
                .AddTransient<IPhoneBookServices, PhoneBookServices>()
                .BuildServiceProvider();
            return serviceProvider;
        }
    }
}
