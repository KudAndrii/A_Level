using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuleTaskFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTaskFour.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(p => p.ArtistId)
                .ValueGeneratedNever();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.DateOfBirth)
                .IsRequired()
                .HasColumnType("date");

            builder.Property(p => p.Email)
                .HasMaxLength(50);

            builder.HasData(new[]
            {
                new Artist
                {
                ArtistId = 1,
                Name = "Sergey Lazarev",
                DateOfBirth = new DateTime(1983, 4, 1),
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "Jared Leto",
                    DateOfBirth = new DateTime(1971, 12, 26)
                },
                new Artist
                {
                    ArtistId = 3,
                    Name = "Johny Depp",
                    DateOfBirth = new DateTime(1963, 6, 9)
                }
            } );
        }
    }
}
