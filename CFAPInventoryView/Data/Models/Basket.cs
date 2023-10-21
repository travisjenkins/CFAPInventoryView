using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFAPInventoryView.Data.Models
{
    public class Basket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid BasketId { get; set; }

        [Required]
        [Display(Name = "Age Group")]
        public Guid AgeGroupId { get; set; }

        [Required]
        [Display(Name = "Ethnicity")]
        public Guid EthnicityId { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Guid GenderId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Assembled")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime DateAssembled { get; set; } = DateTime.Today;

        [Required]
        [Range(1, 1000)]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Safe Stock Level")]
        public int SafeStockLevel { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        [Display(Name = "Age Group")]
        public virtual AgeGroup AgeGroup { get; set; } = null!;

        public virtual Ethnicity Ethnicity { get; set; } = null!;

        public virtual Gender Gender { get; set; } = null!;

        [Display(Name = "iBelong Basket")]
        public virtual ICollection<ProductBasket>? ProductBaskets { get; set; }

        [Display(Name = "iBelong Basket")]
        public virtual ICollection<CategoryBasket>? CategoryBaskets { get; set; }
    }
}
