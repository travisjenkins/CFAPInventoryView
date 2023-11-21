using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class BasketTransaction
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid BasketTransactionId { get; set; }

        public Guid BasketId { get; set; }

        public Guid RecipientId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Distributed")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime DateDistributed { get; set; }

        [Display(Name = "Duration on Shelf")]
        public long? DurationOnShelf
        {
            get
            {
                if (Basket is not null)
                {
                    return (DateDistributed - Basket.DateAssembled).Ticks;
                }
                return default;
            }
        }

        [Display(Name = "Distributed By")]
        public string? DistributedBy { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        public virtual Basket Basket { get; set; } = null!;
        public virtual Recipient Recipient { get; set; } = null!;
    }
}
