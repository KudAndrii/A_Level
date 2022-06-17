using System;
using System.Globalization;
using PhoneBook.Services;
using PhoneBook.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DIContainer container = new DIContainer();
            var load = container.Load();
            var run = load.GetService<Run>();
        }
    }
}
