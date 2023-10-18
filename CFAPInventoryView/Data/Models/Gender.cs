using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Gender
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid GenderId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
    }
}
