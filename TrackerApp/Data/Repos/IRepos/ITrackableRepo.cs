using TrackerApp.Models;

namespace TrackerApp.Data.Repos.IRepos
{
    public interface ITrackableRepo
    {
      
        Task<Trackable?> GetByIdAsync(Guid id, string userId);

        // CREATE
        Task<Trackable> CreateAsync(Trackable trackable);

        // UPDATE
        Task<bool> UpdateAsync(Trackable trackable);

        // DELETE
        Task<bool> DeleteAsync(Guid id, string userId);

        // OPTIONAL: Existence check
        Task<bool> ExistsAsync(Guid id, string userId);
    }
}
