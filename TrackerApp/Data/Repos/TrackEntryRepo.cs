using TrackerApp.Data.Repos.IRepos;
using TrackerApp.Models;

namespace TrackerApp.Data.Repos
{
    public class TrackEntryRepo : ITrackEntryRepo
    {
        public Task<TrackEntry> CreateAsync(TrackEntry entry)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrackEntry>> GetAllAsync(Guid trackableId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrackEntry>> GetAllByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TrackEntry>> GetByDateRangeAsync(Guid trackableId, string userId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<TrackEntry?> GetByIdAsync(Guid id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TrackEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}
