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

        [ScaffoldColumn(false)]
        public bool IsShoppingListItem { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13,4)]
        [Display(Name = "Total Price")]
        public decimal TotalPrice
        {
            get
            {
                if (ProductBaskets is not null && ProductBaskets.Count > 0)
                {
                    decimal totalPrice = 0;
                    foreach (var item in ProductBaskets)
                    {
                        if (item.Product is not null)
                        {
                            totalPrice += item.Product.Price;
                        }
                    }
                    return totalPrice;
                }
                return 0;
            }
        }

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        [Display(Name = "Age Group")]
        public virtual AgeGroup? AgeGroup { get; set; }

        public virtual Ethnicity? Ethnicity { get; set; }

        public virtual Gender? Gender { get; set; }

        [Display(Name = "Products")]
        public virtual ICollection<ProductBasket>? ProductBaskets { get; set; }

        [Display(Name = "Categories")]
        public virtual ICollection<CategoryBasket>? CategoryBaskets { get; set; }
    }
}
