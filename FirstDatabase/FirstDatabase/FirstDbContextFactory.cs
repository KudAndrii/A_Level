using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace FirstDatabase
{
    internal class FirstDbContextFactory : IDesignTimeDbContextFactory<FirstDbContext>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-GJG4K2E;Initial Catalog = FirstDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public FirstDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FirstDbContext>();
            var options = optionsBuilder
                .UseSqlServer(_connectionString)
                .Options;

            return new FirstDbContext(options);
        }
    }
}
