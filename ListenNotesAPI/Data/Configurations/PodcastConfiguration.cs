using System.Threading.Tasks.Sources;
using ListenNotesAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ListenNotesAPI.Data.Configurations
{
    public class PodcastConfiguration : IEntityTypeConfiguration<PodcastModel>
    {
        // define database table properties for ef
        public void Configure(EntityTypeBuilder<PodcastModel> builder)
        {
            builder.HasKey(p => p.Id);

            // make one to many relationship
            builder.HasMany(p => p.Genres).WithOne(); 

            builder.ToTable("Podcast");
        }
    }
}
