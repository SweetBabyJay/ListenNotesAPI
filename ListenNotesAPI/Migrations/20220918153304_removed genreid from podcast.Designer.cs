// <auto-generated />
using System;
using ListenNotesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    [DbContext(typeof(PodcastDbContext))]
    [Migration("20220918153304_removed genreid from podcast")]
    partial class removedgenreidfrompodcast
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.GenreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1L)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PodcastModelId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PodcastModelId1");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.PodcastModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EpisodeTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GenreModelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ITunes_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsClaimed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ListenNotes_URL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rss")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GenreModelId");

                    b.ToTable("Podcast", (string)null);
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.GenreModel", b =>
                {
                    b.HasOne("ListenNotesAPI.Domain.Models.PodcastModel", null)
                        .WithMany("Genres")
                        .HasForeignKey("PodcastModelId1");
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.PodcastModel", b =>
                {
                    b.HasOne("ListenNotesAPI.Domain.Models.GenreModel", null)
                        .WithMany("Podcasts")
                        .HasForeignKey("GenreModelId");
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.GenreModel", b =>
                {
                    b.Navigation("Podcasts");
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.PodcastModel", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
