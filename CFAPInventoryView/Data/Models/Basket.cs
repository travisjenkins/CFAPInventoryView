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

        [Range(1, 1000)]
        [Display(Name = "Basket #")]
        public int? BasketNumber { get; set; }

        public string BasketDisplayName
        {
            get => $"Basket:  #{BasketNumber}, Age Group:  {AgeGroup?.Description}, Ethnicity:  {Ethnicity?.Description}, Gender:  {Gender?.Description}";
        }

        [Required]
        [Display(Name = "Age Group")]
        public Guid AgeGroupId { get; set; }

        [Required]
        [Display(Name = "Ethnicity")]
        public Guid EthnicityId { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Guid GenderId { get; set; }

        [Display(Name = "Storage Location")]
        public Guid? StorageLocationId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Assembled")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy}")]
        public DateTime DateAssembled { get; set; } = DateTime.Today;

        [Range(0, 1000)]
        public int? Quantity { get; set; }

        [Display(Name = "Needed")]
        public int QuantityNeeded
        {
            get
            {
                if (IsShoppingListItem && SafeStockLevel.HasValue && Quantity.HasValue)
                {
                    if (SafeStockLevel.Value - Quantity.Value >= 0)
                    {
                        return SafeStockLevel.Value - Quantity.Value;
                    }
                }
                return 0;
            }
        }

        [Range(1, 1000)]
        [Display(Name = "Safe Stock Level")]
        public int? SafeStockLevel { get; set; }

        [ScaffoldColumn(false)]
        public bool IsShoppingListItem { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13,4)]
        [Display(Name = "Total Price")]
        public decimal TotalPrice
        {
            get
            {
                if (SupplyBaskets is not null && SupplyBaskets.Count > 0)
                {
                    decimal totalPrice = 0;
                    foreach (var item in SupplyBaskets)
                    {
                        if (item.Supply is not null)
                        {
                            totalPrice += item.Supply.Price;
                        }
                    }
                    return totalPrice;
                }
                return 0;
            }
        }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        [Display(Name = "Age Group")]
        public virtual AgeGroup? AgeGroup { get; set; }

        public virtual Ethnicity? Ethnicity { get; set; }

        public virtual Gender? Gender { get; set; }

        public virtual StorageLocation? StorageLocation { get; set; }

        [Display(Name = "Supplies")]
        public virtual ICollection<SupplyBasket> SupplyBaskets { get; set; } = new List<SupplyBasket>();

        [Display(Name = "Categories")]
        public virtual ICollection<CategoryBasket> CategoryBaskets { get; set; } = new List<CategoryBasket>();
    }
}
