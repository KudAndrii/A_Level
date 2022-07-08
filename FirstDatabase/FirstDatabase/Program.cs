using FirstDatabase.Services;
using FirstDatabase.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FirstDatabase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new Container().Load();
            using (var context = container.GetService<Context>())
            {
            }
        }
    }
}