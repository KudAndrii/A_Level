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
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(p => p.GenreId)
                .ValueGeneratedNever();

            builder.Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasData(new[]
            {
                new Genre
                {
                    GenreId = 1,
                    Title = "Pop"
                },
                new Genre
                {
                    GenreId = 2,
                    Title = "Alternative Rock"
                },
                new Genre
                {
                    GenreId = 3,
                    Title = "Hard Rock"
                },
                new Genre
                {
                    GenreId = 4,
                    Title = "Rock"
                }
            });
        }
    }
}
