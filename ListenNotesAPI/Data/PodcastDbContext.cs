using Microsoft.EntityFrameworkCore;
using ListenNotesAPI.Data.Configurations;
using ListenNotesAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ListenNotesAPI.Data
{
    public class PodcastDbContext : DbContext
    {
        public DbSet<PodcastModel> Podcasts { get; set; }
        public DbSet<GenreModel> Genres { get; set; }

        public PodcastDbContext(DbContextOptions<PodcastDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // apply custom configs
            builder.ApplyConfiguration(new PodcastConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
        }
    }
}
