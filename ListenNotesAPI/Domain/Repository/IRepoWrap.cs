namespace ListenNotesAPI.Domain.Repository
{
    public interface IRepoWrap : IDisposable
    {
        IPodcastRepository Podcasts { get; }
        Task<int> CommitAsync();
    }
}
