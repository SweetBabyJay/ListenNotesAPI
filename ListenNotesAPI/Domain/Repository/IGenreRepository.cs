using ListenNotesAPI.Domain.Models;

namespace ListenNotesAPI.Domain.Repository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<GenreModel>> GetByPodcastID(int podcastId);
    }
}
