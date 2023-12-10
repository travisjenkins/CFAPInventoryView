using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFAPInventoryView.Data.Models
{
    public class Supply
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid SupplyId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Display(Name = "Category")]
        public Guid? CategoryId { get; set; }

        [Display(Name = "Optional Category")]
        public Guid? OptionalCategoryId { get; set; }

        [Display(Name = "Exclude Category")]
        public Guid? ExcludeCategoryId { get; set; }

        [Required]
        [Display(Name = "Storage Location")]
        public Guid StorageLocationId { get; set; }

        [Display(Name = "Donor")]
        public Guid? DonorId { get; set; }

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
        public DateTime PurchaseDate { get; set; } = DateTime.Today;

        [Required]
        [Range(1, 1000)]
        public int Quantity { get; set; }

        [Required]
        // This will format it for us
        [DataType(DataType.Currency)]
        /* 
         * Precision(total number of digits, number of digits to the right of the decimal)
         * This would allow a value up to 999,999,999.9999
         */
        [Precision(13,4)]
        [Display(Name = "Price (EA)")]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13,4)]
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get => Price * Quantity; }

        [StringLength(100)]
        public string? Barcode { get; set; }

        public bool Active { get; set; } = true;

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        public virtual Category? Category { get; set; }

        [Display(Name = "Optional Category")]
        public virtual OptionalCategory? OptionalCategory { get; set; }

        [Display(Name = "Exclude Category")]
        public virtual ExcludeCategory? ExcludeCategory { get; set; }

        [Display(Name = "Storage Location")]
        public virtual StorageLocation? StorageLocation { get; set; }

        public virtual Donor? Donor { get; set; }
    }
}
