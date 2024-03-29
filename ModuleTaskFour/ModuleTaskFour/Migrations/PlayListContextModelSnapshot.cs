﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuleTaskFour;

#nullable disable

namespace ModuleTaskFour.Migrations
{
    [DbContext(typeof(PlayListContext))]
    partial class PlayListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ModuleTaskFour.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            DateOfBirth = new DateTime(1983, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sergey Lazarev"
                        },
                        new
                        {
                            ArtistId = 2,
                            DateOfBirth = new DateTime(1971, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jared Leto"
                        },
                        new
                        {
                            ArtistId = 3,
                            DateOfBirth = new DateTime(1963, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Johny Depp"
                        });
                });

            modelBuilder.Entity("ModuleTaskFour.Models.ArtistSong", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            SongId = 2
                        },
                        new
                        {
                            ArtistId = 2,
                            SongId = 3
                        },
                        new
                        {
                            ArtistId = 3,
                            SongId = 1
                        });
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Title = "Pop"
                        },
                        new
                        {
                            GenreId = 2,
                            Title = "Alternative Rock"
                        },
                        new
                        {
                            GenreId = 3,
                            Title = "Hard Rock"
                        },
                        new
                        {
                            GenreId = 4,
                            Title = "Rock"
                        });
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Duration = "01:28",
                            GenreId = 4,
                            ReleasedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Isolation"
                        },
                        new
                        {
                            SongId = 2,
                            Duration = "04:21",
                            GenreId = 1,
                            ReleasedDate = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Сдавайся"
                        },
                        new
                        {
                            SongId = 3,
                            Duration = "05:30",
                            GenreId = 2,
                            ReleasedDate = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Kill"
                        });
                });

            modelBuilder.Entity("ModuleTaskFour.Models.ArtistSong", b =>
                {
                    b.HasOne("ModuleTaskFour.Models.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuleTaskFour.Models.Song", "Song")
                        .WithMany("Performers")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Song", b =>
                {
                    b.HasOne("ModuleTaskFour.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("ModuleTaskFour.Models.Song", b =>
                {
                    b.Navigation("Performers");
                });
#pragma warning restore 612, 618
        }
    }
}
