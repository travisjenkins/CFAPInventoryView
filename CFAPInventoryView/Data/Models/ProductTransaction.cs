using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class ProductTransaction
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProductTransactionId { get; set; }

        public Guid ProductId { get; set; }

        public Guid DonorId { get; set; }

        public Guid ParentId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Distributed")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime DateDistributed { get; set; }

        [Display(Name = "Duration on Shelf")]
        public long? DurationOnShelf
        {
            get
            {
                if (Product is not null)
                {
                    return (DateDistributed - Product.PurchaseDate).Ticks;
                }
                return default;
            }
        }

        [Display(Name = "Distributed By")]
        public string? DistributedBy { get; set; }
        
        public Product Product { get; set; } = null!;
        public Donor Donor { get; set; } = null!;
        public Parent Parent { get; set; } = null!;
    }
}
