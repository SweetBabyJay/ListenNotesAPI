using ListenNotesAPI.Domain.Repository;
using ListenNotesAPI.Data.Repositories;
using ListenNotesAPI.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace ListenNotesAPI.Data
{
    public class RepoWrap : IRepoWrap
    {
        private readonly PodcastDbContext _dbcontext;
        private PodcastRepository _podcastRepository;

        public RepoWrap(PodcastDbContext context)
        {
            this._dbcontext = context;
        }

        public IPodcastRepository Podcasts => _podcastRepository ?? new PodcastRepository(_dbcontext);

        public async Task<int> CommitAsync()
        {
            return await _dbcontext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}
