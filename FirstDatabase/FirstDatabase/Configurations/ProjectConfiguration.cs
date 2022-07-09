using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstDatabase.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.BudGet)
                .HasColumnType("money");

            builder.Property(p => p.ClientId)
                .IsRequired();

            builder.HasData(new[]
            {
                new Project
                {
                    ProjectId = 1,
                    Name = "Some1",
                    BudGet = 100,
                    StartedDate = DateTime.Now,
                    ClientId = 1
                },
                new Project
                {
                    ProjectId = 2,
                    Name = "Some2",
                    BudGet = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 3
                },
                new Project
                {
                    ProjectId = 3,
                    Name = "Some3",
                    BudGet = 300,
                    StartedDate = DateTime.Now,
                    ClientId = 4
                }
            });
        }
    }
}
