namespace TrackerApp.Models
{
    public class TrackEntry
    {
        public Guid Id { get; set; }
        public Guid TrackableId { get; set; }
        public Trackable Trackable { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public decimal Value { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
