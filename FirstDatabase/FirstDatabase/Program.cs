using Microsoft.Extensions.DependencyInjection;

namespace FirstDatabase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new FirstDbContextFactory().CreateDbContext(Array.Empty<string>()))
            {
            }
        }
    }
}