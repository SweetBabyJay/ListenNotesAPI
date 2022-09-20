using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ListenNotesAPI.Domain.Models
{
    public class GenreModel
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PodcastModelId { get; set; }

        public GenreModel(int id)
        {
            Id = id;
        }
    }
}
