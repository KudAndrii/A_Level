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
    public class ArtistSongConfiruration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasKey(k => new { k.ArtistId, k.SongId });

            builder.Property(p => p.ArtistId)
                .ValueGeneratedNever();

            builder.Property(p => p.SongId)
                .ValueGeneratedNever();

            builder.HasData(new[]
            {
                new ArtistSong
                {
                    ArtistId = 1,
                    SongId = 2
                },
                new ArtistSong
                {
                    ArtistId = 2,
                    SongId = 3
                },
                new ArtistSong
                {
                    ArtistId = 3,
                    SongId = 1
                }
            });
        }
    }
}
