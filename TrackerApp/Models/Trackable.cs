using Microsoft.AspNetCore.Identity;

namespace TrackerApp.Models
{
    public class Trackable
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Unit { get; set; }
        public string? Color { get; set; }
        public string? Icon { get; set; }
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
