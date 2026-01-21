using TrackerApp.Data.Repos.IRepos;
using TrackerApp.Exceptions;
using TrackerApp.Models;

namespace TrackerApp.Services.IServices
{
    public class TrackableService : ITrackableService
    {
        private readonly ITrackableRepo _trackableRepo;

        public TrackableService(ITrackableRepo trackableRepo)
        {
            _trackableRepo = trackableRepo;
        }

        public async Task<Trackable> CreateAsync(Trackable trackable, string userId)
        {
            if (trackable == null)
                throw new ArgumentNullException(nameof(trackable));
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("User ID is required", nameof(userId));
            if (string.IsNullOrWhiteSpace(trackable.Name))
                throw new ArgumentException("Trackable name is required", nameof(trackable.Name));

            trackable.Id = Guid.NewGuid();
            trackable.UserId = userId;
            trackable.CreatedAt = DateTime.UtcNow;

            return await _trackableRepo.CreateAsync(trackable);
        }

        public async Task<bool> DeleteAsync(Guid id, string userId)
        {
            var trackable = await _trackableRepo.GetByIdAsync(id, userId);
            if (trackable == null)
                throw new NotFoundException($"Trackable with ID {id} not found or you are not authorized.");

            return await _trackableRepo.DeleteAsync(id, userId);
        }

        public async Task<bool> ExistsAsync(Guid id, string userId)
        {
            return await _trackableRepo.ExistsAsync(id, userId);
        }

        public async Task<Trackable?> GetByIdAsync(Guid id, string userId)
        {
            var trackable = await _trackableRepo.GetByIdAsync(id, userId);
            if (trackable == null)
                throw new NotFoundException($"Trackable with ID {id} not found or you are not authorized.");

            return trackable;
        }

        public async Task<bool> UpdateAsync(Trackable trackable, string userId)
        {
            if (trackable == null)
                throw new ArgumentNullException(nameof(trackable));
            if (string.IsNullOrWhiteSpace(userId))
                throw new ArgumentException("User ID is required", nameof(userId));
            if (string.IsNullOrWhiteSpace(trackable.Name))
                throw new ArgumentException("Trackable name is required", nameof(trackable.Name));

            var existing = await _trackableRepo.GetByIdAsync(trackable.Id, userId);
            if (existing == null)
                throw new NotFoundException($"Trackable with ID {trackable.Id} not found or you are not authorized.");

            // Preserve UserId and CreatedAt
            trackable.UserId = existing.UserId;
            trackable.CreatedAt = existing.CreatedAt;

            return await _trackableRepo.UpdateAsync(trackable);
        }
    }

}
