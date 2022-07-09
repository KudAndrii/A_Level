using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using FirstDatabase.Interfaces;

namespace FirstDatabase
{
    internal class FirstDbContextFactory : IDesignTimeDbContextFactory<FirstDbContext>
    {
        private readonly string _connectionString;
        public FirstDbContextFactory(IConfigService configService)
        {
            _connectionString = configService.DBConfig.ConnectionString;
        }

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
