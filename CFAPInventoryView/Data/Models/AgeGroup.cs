using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class AgeGroup
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid AgeGroupId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string? Group { get; set; }
    }
}
