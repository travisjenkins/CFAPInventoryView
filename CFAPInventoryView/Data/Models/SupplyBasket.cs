using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class SupplyBasket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid SupplyBasketId { get; set; }

        [Required]
        public Guid BasketId { get; set; }

        [Required]
        public Guid SupplyId { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        public virtual Supply Supply { get; set; } = null!;
    }
}
