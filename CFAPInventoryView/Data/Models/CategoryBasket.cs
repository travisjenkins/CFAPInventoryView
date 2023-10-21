using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class CategoryBasket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid CategoryBasketId { get; set; }

        [Required]
        public Guid BasketId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public Guid? OptionalCategoryId { get; set; }

        public Guid? ExcludeCategoryId { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        [Display(Name = "Category")]
        public virtual Category Category { get; set; } = null!;

        [Display(Name = "Optional Category")]
        public virtual OptionalCategory OptionalCategory { get; set; } = null!;

        [Display(Name = "Exclude Category")]
        public virtual ExcludeCategory ExcludeCategory { get; set; } = null!;
    }
}
