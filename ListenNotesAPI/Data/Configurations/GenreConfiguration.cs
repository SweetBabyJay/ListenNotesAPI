using ListenNotesAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ListenNotesAPI.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<GenreModel>
    {
        // define database table properties for ef
        public void Configure(EntityTypeBuilder<GenreModel> builder)
        {
            builder.HasKey(g => new { g.Id, g.PodcastModelId});

            builder.ToTable("Genre");
        }
    }
}
