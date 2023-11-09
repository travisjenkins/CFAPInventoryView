namespace CFAPInventoryView.Models
{
    public class AssignedProductViewModel
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public bool Assigned { get; set; }
    }
}
