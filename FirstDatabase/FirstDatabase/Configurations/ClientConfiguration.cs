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
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(p => p.Login)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.RegistrationDate)
            .HasColumnType("date")
            .HasDefaultValueSql("getdate()");

            builder.HasData(new[]
            {
                new Client
                {
                    ClientId = 1,
                    Login = "Jerry",
                    Password = "1234",
                    Age = 14
                },
                new Client
                {
                    ClientId = 2,
                    Login = "Sara",
                    Password = "0000",
                    Age = 20
                },
                new Client
                {
                    ClientId = 3,
                    Login = "John",
                    Password = "1111",
                    Age = 43
                },
                new Client
                {
                    ClientId = 4,
                    Login = "Joe",
                    Password = "0000",
                    Age = 30
                },
                new Client
                {
                    ClientId = 5,
                    Login = "Din",
                    Password = "1",
                    Age = 25
                }
            });
        }
    }
}
