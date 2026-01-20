using Microsoft.EntityFrameworkCore;
using TrackerApp.Data.Repos.IRepos;
using TrackerApp.Models;

namespace TrackerApp.Data.Repos
{
    public class TrackableRepo : ITrackableRepo
    {
        public readonly AppDbContext _context;

        public TrackableRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Trackable> CreateAsync(Trackable trackable)
        {
            trackable.Id = Guid.NewGuid();
            trackable.CreatedAt = DateTime.UtcNow;
                
            _context.Trackables.Add(trackable);
            await _context.SaveChangesAsync();

            return trackable;
        }


        public async Task<bool> DeleteAsync(Guid id, string userId)
        {
 
            var trackable = await _context.Trackables
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (trackable == null)
                return false;

            _context.Trackables.Remove(trackable);
            await _context.SaveChangesAsync();

            return true;
        }


        public Task<bool> ExistsAsync(Guid id, string userId)
        {
            var trackableExists = _context.Trackables
                .AnyAsync(t => t.Id == id && t.UserId == userId);

            return trackableExists;
        }

        public async Task<Trackable?> GetByIdAsync(Guid id, string userId)
        {
            var trackable =  await _context.Trackables
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (trackable == null)
                return await Task.FromResult<Trackable?>(null);

            return trackable;
        }

        public async Task<bool> UpdateAsync(Trackable trackable)
        {
            
            var trackableToUpdate = await _context.Trackables
                .FirstOrDefaultAsync(t => t.Id == trackable.Id && t.UserId == trackable.UserId);

           
            if (trackableToUpdate == null)
                return false;

            
            trackableToUpdate.Name = trackable.Name;
            trackableToUpdate.Unit = trackable.Unit;
            trackableToUpdate.Color = trackable.Color;
            trackableToUpdate.Icon = trackable.Icon;

            
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
