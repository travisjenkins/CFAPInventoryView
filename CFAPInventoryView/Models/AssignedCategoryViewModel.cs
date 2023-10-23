namespace CFAPInventoryView.Models
{
    public class AssignedCategoryViewModel
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public bool Assigned { get; set; }
    }
}
