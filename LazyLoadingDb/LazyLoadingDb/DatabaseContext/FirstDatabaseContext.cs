using System;
using System.Collections.Generic;
using LazyLoadingDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LazyLoadingDb.DatabaseContext
{
    public partial class FirstDatabaseContext : DbContext
    {
        private readonly string _connectionString;
        public FirstDatabaseContext()
        {
            var connectionString = Environment.GetEnvironmentVariable("LocalFirstDatabaseConnection");
            _connectionString = connectionString;
        }

        public FirstDatabaseContext(DbContextOptions<FirstDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Title> Titles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.OfficeId, "IX_Employee_OfficeId");

                entity.HasIndex(e => e.TitleId, "IX_Employee_TitleId");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.OfficeId);

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TitleId);
            });

            modelBuilder.Entity<EmployeeProject>(entity =>
            {
                entity.ToTable("EmployeeProject");

                entity.HasIndex(e => e.EmployeeId, "IX_EmployeeProject_EmployeeId");

                entity.HasIndex(e => e.ProjectId, "IX_EmployeeProject_ProjectId");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.EmployeeId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EmployeeProjects)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("Office");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.BudGet).HasColumnType("money");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.ToTable("Title");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
