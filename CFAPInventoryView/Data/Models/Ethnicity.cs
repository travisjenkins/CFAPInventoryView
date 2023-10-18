using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Ethnicity
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid EthnicityId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
    }
}
