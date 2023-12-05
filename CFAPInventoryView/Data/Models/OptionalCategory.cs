using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class OptionalCategory
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid OptionalCategoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Safe Stock Level")]
        public int SafeStockLevel { get; set; }

        [Display(Name = "Needed")]
        public int QuantityNeeded
        {
            get
            {
                if (SafeStockLevel - Quantity >= 0)
                {
                    return (SafeStockLevel - Quantity) + 1;
                }
                return 0;
            }
        }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        public ICollection<AgeGroupCategory> AgeGroups { get; set; } = new List<AgeGroupCategory>();
    }
}
