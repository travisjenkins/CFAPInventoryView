namespace CFAPInventoryView.Services
{
    public class RateLimitOptions
    {
        public string? PolicyName { get; set; }
        public int PermitLimit { get; set; }
        public int Window { get; set; }
        public int QueueLimit { get; set; }
    }
}
