using ListenNotesAPI.Domain.Models;

namespace ListenNotesAPI.Domain.Repository
{
    public interface IPodcastRepository : IRepository<PodcastModel>
    {
        Task<IEnumerable<PodcastModel>> GetAll();
        void Save(PodcastModel podcast);
    }
}
