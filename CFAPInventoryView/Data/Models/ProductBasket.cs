using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class ProductBasket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProductBasketId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid BasketId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Display(Name = "Product")]
        public virtual Product Product { get; set; } = null!;
    }
}
