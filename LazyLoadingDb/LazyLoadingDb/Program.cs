namespace LazyLoadingDb
{
    using LazyLoadingDb.DatabaseContext;
    using LazyLoadingDb.Models;
    using LazyLoadingDb.IoC;
    using LazyLoadingDb.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var container = new Container().Load();
            await using (var db = container.GetService<FirstDatabaseContext>())
            {
                var requests = container.GetService<IRequestList>();

                // First request
                var request1 = Task.Run(() => {
                    requests.DateDifference();
                });
                await request1;

                // Second request
                var request2 = Task.Run(() =>
                {
                    requests.ModifyEntites();
                });
                await request2;
                db.SaveChanges();

                // Third request

            }
        }
    }
}