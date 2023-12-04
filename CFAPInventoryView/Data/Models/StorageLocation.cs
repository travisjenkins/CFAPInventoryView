using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class StorageLocation
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid StorageLocationId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? Shelf { get; set; }

        [Range(1, 50)]
        public int? Row { get; set; }

        [Range(1, 50)]
        public int? Column { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }
    }
}
