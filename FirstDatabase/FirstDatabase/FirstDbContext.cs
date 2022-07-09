using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstDatabase.Configurations;
using FirstDatabase.Models;
using Microsoft.EntityFrameworkCore;
using FirstDatabase.Configs;
using FirstDatabase.Interfaces;
using FirstDatabase.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FirstDatabase
{
    internal class FirstDbContext : DbContext
    {
        public FirstDbContext(DbContextOptions<FirstDbContext> options)
        : base(options)
        {
        }

        public DbSet<Client>? Client { get; set; }
        public DbSet<Employee>? Employee { get; set; }
        public DbSet<EmployeeProject>? EmployeeProject { get; set; }
        public DbSet<Office>? Office { get; set; }
        public DbSet<Project>? Project { get; set; }
        public DbSet<Title>? Title { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }
    }
}
