using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Donor
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid DonorId { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Name")]
        public string? FullName
        {
            get => $"{FirstName} {LastName}";
        }

        [PersonalData]
        [Required]
        [Display(Name = "Address")]
        public string? Address1 { get; set; }

        [PersonalData]
        [Display(Name = "Address (cont)")]
        public string? Address2 { get; set; }

        [PersonalData]
        [Required]
        public string? City { get; set; }

        [PersonalData]
        [Required]
        public string? State { get; set; }

        [PersonalData]
        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        [Display(Name = "Supplies Donated")]
        public virtual ICollection<SupplyTransaction> SupplyTransactions { get; set; } = new List<SupplyTransaction>();

        [Display(Name = "Baskets Donated")]
        public virtual ICollection<BasketTransaction> BasketTransactions { get; set; } = new List<BasketTransaction>();

        [DataType(DataType.Currency)]
        [Precision(13,4)]
        [Display(Name = "Total of Donations")]
        public decimal TotalOfDonations 
        { 
            get
            {
                decimal total = 0;
                if (SupplyTransactions.Count > 0)
                {
                    foreach (var transaction in SupplyTransactions)
                    {
                        if (transaction.Supply is not null)
                        {
                            total += transaction.Supply.Price;
                        }
                    }
                }
                if (BasketTransactions.Count > 0)
                {
                    foreach (var transaction in BasketTransactions)
                    {
                        if (transaction.Basket is not null)
                        {
                            total += transaction.Basket.TotalPrice;
                        }
                    }
                }
                return total;
            } 
        }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }
    }
}
