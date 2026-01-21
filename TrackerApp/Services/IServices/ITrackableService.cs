using TrackerApp.Models;

namespace TrackerApp.Services.IServices
{
    public interface ITrackableService
    {
        Task<Trackable> CreateAsync(Trackable trackable, string userId);
        Task<bool> UpdateAsync(Trackable trackable, string userId);
        Task<bool> DeleteAsync(Guid id, string userId);
        Task<Trackable?> GetByIdAsync(Guid id, string userId);
        Task<bool> ExistsAsync(Guid id, string userId);
    }
}
