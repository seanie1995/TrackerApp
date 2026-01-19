using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrackerApp.Models;

namespace TrackerApp.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Trackable> Trackables { get; set; }
        public DbSet<TrackEntry> TrackEntries { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
