﻿// <auto-generated />
using ListenNotesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    [DbContext(typeof(PodcastDbContext))]
    [Migration("20220918154231_made composite key")]
    partial class madecompositekey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.GenreModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PodcastModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("Id", "PodcastModelId");

                    b.HasIndex("PodcastModelId");

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

                    b.ToTable("Podcast", (string)null);
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.GenreModel", b =>
                {
                    b.HasOne("ListenNotesAPI.Domain.Models.PodcastModel", null)
                        .WithMany("Genres")
                        .HasForeignKey("PodcastModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ListenNotesAPI.Domain.Models.PodcastModel", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}