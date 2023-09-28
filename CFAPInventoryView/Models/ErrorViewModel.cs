namespace CFAPInventoryView.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string? FriendlyErrorMessage { get; set; }
    }
}