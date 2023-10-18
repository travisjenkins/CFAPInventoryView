using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFAPInventoryView.Data.Models
{
    public class Basket
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid BasketId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid AgeGroupId { get; set; }

        [Required]
        public Guid EthnicityId { get; set; }

        [Required]
        public Guid GenderId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Assembled")]
        public DateTime DateAssembled { get; set; } = DateTime.Today;

        private decimal _totalValue;
        // This will format it for us
        [DataType(DataType.Currency)]
        [Display(Name = "Total Value")]
        /* 
         * Precision(total number of digits, number of digits to the right of the decimal)
         * This would allow a value up to 999,999,999.9999
         */
        [Precision(13,4)]
        public decimal TotalValue 
        {
            get => _totalValue;
            
            private set 
            {
                if (IncludeProducts is not null)
                {
                    foreach (var item in IncludeProducts)
                    {
                        if (item is not null)
                        {
                            _totalValue += item.Price;
                        }
                    }
                }
                if (OptionalProducts is not null)
                {
                    foreach (var item in OptionalProducts)
                    {
                        if (item is not null)
                        {
                            _totalValue += item.Price;
                        }
                    }
                }
            } 
        }

        [InverseProperty("IncludeBasket")]
        [Display(Name = "Include Products")]
        public ICollection<Product> IncludeProducts { get; } = new List<Product>();

        [InverseProperty("OptionalBasket")]
        [Display(Name = "Optional Products")]
        public ICollection<Product>? OptionalProducts { get; }

        [InverseProperty("ExcludeBasket")]
        [Display(Name = "Exclude Products")]
        public ICollection<Product>? ExcludeProducts { get; }

        [Display(Name = "Age Group")]
        public virtual AgeGroup AgeGroup { get; set; } = null!;

        [Display(Name = "Ethnicity")]
        public virtual Ethnicity Ethnicity { get; set; } = null!;

        [Display(Name = "Gender")]
        public virtual Gender Gender { get; set; } = null!;
    }
}
