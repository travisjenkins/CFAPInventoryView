using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class ProductBasket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProductBasketId { get; set; }

        [Required]
        public Guid BasketId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        [Display(Name = "iBelong Basket")]
        public virtual Basket Basket { get; set; } = null!;
    }
}
