namespace CFAPInventoryView.Data.Models
{
    public class AgeGroupCategory
    {
        public Guid AgeGroupCategoryId { get; set; }
        public Guid AgeGroupId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? OptionalCategoryId { get; set; }
        public Guid? ExcludeCategoryId { get; set; }
        public virtual AgeGroup AgeGroup { get; set; } = null!;
    }
}
