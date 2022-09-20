using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListenNotesAPI.Data.Repositories;
using ListenNotesAPI.Domain.Models;
using ListenNotesAPI.Domain.Repository;

namespace ListenNotesAPI.Data.Repository
{
    public class PodcastRepository : Repository<PodcastModel>, IPodcastRepository
    {
        public PodcastRepository(PodcastDbContext context) : base(context) { }

        public async Task<IEnumerable<PodcastModel>> GetAll()
        {
            // tie genres to podcasts using include
            return await PodcastDbContext.Podcasts.Include(p => p.Genres).ToListAsync();
        }

        public void Save(PodcastModel podcast)
        {
            // temporary hacky method to get around unique constraint when it was violated trying to insert data into sqlite db
            // uncomment if needed - error generally happened with first entry as i was figuring out how to insert data
            //PodcastDbContext.Podcasts.Remove(podcast);

            PodcastDbContext.Podcasts.Add(podcast);
            
            PodcastDbContext.SaveChangesAsync();
        }

        private PodcastDbContext PodcastDbContext
        {
            get
            {
                return _dbContext as PodcastDbContext;
            }
        }
    }
}
