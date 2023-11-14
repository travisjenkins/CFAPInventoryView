using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Parent
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ParentId { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

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

        [Display(Name = "Foster Parent")]
        public bool IsFosterParent { get; set; }

        [Display(Name = "Adoptive Parent")]
        public bool IsAdoptiveParent { get; set; }

        [Display(Name = "Products Received")]
        public virtual ICollection<ProductTransaction> ProductTransactions { get; set; } = new List<ProductTransaction>();

        [Display(Name = "Baskets Received")]
        public virtual ICollection<BasketTransaction> BasketTransactions { get; set; } = new List<BasketTransaction>();

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        [Display(Name = "Total of Donations Received")]
        public decimal TotalOfDonationsReceived
        {
            get
            {
                decimal total = 0;
                if (ProductTransactions.Count > 0)
                {
                    foreach (var transaction in ProductTransactions)
                    {
                        if (transaction.Product is not null)
                        {
                            total += transaction.Product.Price;
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

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }
    }
}
