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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.Property(p => p.SongId)
                .ValueGeneratedNever();

            builder.Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Duration)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(p => p.ReleasedDate)
                .IsRequired()
                .HasColumnType("date");

            builder.HasData(new[]
            {
                new Song
                {
                    SongId = 1,
                    Title = "Isolation",
                    Duration = new TimeOnly(0, 1, 28).ToString("mm:ss"),
                    ReleasedDate = new DateTime(2022, 1, 1),
                    GenreId = 4
                },
                new Song
                {
                    SongId = 2,
                    Title = "Сдавайся",
                    Duration = new TimeOnly(0, 4, 21).ToString("mm:ss"),
                    ReleasedDate = new DateTime(2017, 1, 1),
                    GenreId = 1
                },
                new Song
                {
                    SongId = 3,
                    Title = "The Kill",
                    Duration = new TimeOnly(0, 5, 30).ToString("mm:ss"),
                    ReleasedDate = new DateTime(2005, 1, 1),
                    GenreId = 2
                }
            });
        }
    }
}
