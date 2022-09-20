using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ListenNotesAPI.Domain.Models
{
    public class PodcastModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Thumbnail { get; set; }
        public string ListenNotes_URL { get; set; }
        [JsonProperty("total_episodes")]
        public int EpisodeTotal { get; set; }
        public string Description { get; set; }
        // uses underscores to ensure json deserialization matches with properties. can also use json property data annotation above
        public int ITunes_ID { get; set; }
        public string rss { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public bool IsClaimed { get; set; }
        public string Type { get; set; }
        //used for deserialization only

        [NotMapped]
        public List<int>? Genre_Ids { get; set; }
        public ICollection<GenreModel> Genres { get; set; }        

        public PodcastModel()
        {
            Genres = new Collection<GenreModel>();
        }
    }
}
