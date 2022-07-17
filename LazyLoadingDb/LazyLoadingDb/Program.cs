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
                #region Entity creating
                var employee = new Employee()
                {
                    FirstName = "John",
                    LastName = "Connor",
                    HiredDate = DateTime.Now,
                    DateOfBirth = new DateTime(1985, 2, 28),
                    Title = new Title()
                    {
                        Name = "Human Resourses"
                    },
                    Office = db.Offices.FirstOrDefault()
                };

                var project = new Project()
                {
                    Name = "Super app",
                    BudGet = 500,
                    StartedDate = DateTime.Now,
                    ClientId = db.Clients.SingleOrDefault(c => c.Login == "John").ClientId
                };
                #endregion

                var request3 = Task.Run(() =>
                {
                    requests.AddFullEmployeeAndProjectEntity(employee, project);
                });
                await request3;
                db.SaveChanges();
                
                // Fourth request
                var request4 = Task.Run(() =>
                {
                    requests.DeleteSomeEmployee(1);
                });
                await request4;
                db.SaveChanges();
                
                // Fifth request
                var request5 = Task.Run(() =>
                {
                    requests.GroupByTitle('a');
                });
                await request5;
                
                // Sixth request
                var request6 = Task.Run(() =>
                {
                    requests.SelectTwoConnectedEntites();
                });
                await request6;
                
            }
        }
    }
}