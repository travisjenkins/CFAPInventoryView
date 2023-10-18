using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFAPInventoryView.Data.Models
{
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProductId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public bool Expires { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Expiration Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        // This will format it for us
        [DataType(DataType.Currency)]
        /* 
         * Precision(total number of digits, number of digits to the right of the decimal)
         * This would allow a value up to 999,999,999.9999
         */
        [Precision(13,4)]
        public decimal Price { get; set; }

        [StringLength(100)]
        public string? Barcode { get; set; }

        // Required as ForeignKeys to reference an assigned Basket
        public Guid? IncludeBasketId { get; set; }
        public Guid? OptionalBasketId { get; set; }
        public Guid? ExcludeBasketId { get; set; }

        [ForeignKey(nameof(IncludeBasketId))]
        public virtual Basket? IncludeBasket { get; set; }

        [ForeignKey(nameof(OptionalBasketId))]
        public virtual Basket? OptionalBasket { get; set; }

        [ForeignKey(nameof(ExcludeBasketId))]
        public virtual Basket? ExcludeBasket { get; set; }
    }
}
