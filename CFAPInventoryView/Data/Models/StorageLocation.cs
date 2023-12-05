using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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

        public override string ToString()
        {
            string locationToDisplay = Name ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(Shelf))
            {
                locationToDisplay += $", Shelf:  {Shelf}";
            }
            if (Row.HasValue)
            {
                locationToDisplay += $", Row:  {Row}";
            }
            if (Column.HasValue)
            {
                locationToDisplay += $", Col:  {Column}";
            }
            return locationToDisplay;
        }
    }
}
