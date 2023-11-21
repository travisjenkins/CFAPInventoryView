namespace CFAPInventoryView.Models
{
    public class AssignedSupplyViewModel
    {
        public Guid SupplyId { get; set; }
        public string? Name { get; set; }
        public bool Assigned { get; set; }
    }
}
