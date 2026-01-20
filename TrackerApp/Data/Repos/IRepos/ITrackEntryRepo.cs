using TrackerApp.Models;

namespace TrackerApp.Data.Repos.IRepos
{
    public interface ITrackEntryRepo
    {
        // READ
        Task<IEnumerable<TrackEntry>> GetAllAsync(
            Guid trackableId,
            string userId);

        Task<TrackEntry?> GetByIdAsync(
            Guid id,
            string userId);

        Task<IEnumerable<TrackEntry>> GetAllByUserId(string userId);

        // CREATE
        Task<TrackEntry> CreateAsync(TrackEntry entry);

        // UPDATE
        Task<bool> UpdateAsync(TrackEntry entry);

        // DELETE
        Task<bool> DeleteAsync(
            Guid id,
            string userId);

        // OPTIONAL / COMMON QUERIES
        Task<bool> ExistsAsync(
            Guid id,
            string userId);

        Task<IEnumerable<TrackEntry>> GetByDateRangeAsync(
            Guid trackableId,
            string userId,
            DateTime from,
            DateTime to);
    }
}
