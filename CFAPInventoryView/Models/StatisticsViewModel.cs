using CFAPInventoryView.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Models
{
    public class StatisticsViewModel
    {
        // Products
        [Display(Name = "Total Supplies")]
        public int TotalSupplies { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        [Display(Name = "Total Inventory Price")]
        public decimal TotalInventoryPrice { get; set; }

        [Display(Name = "Total Perishable")]
        public int TotalItemsThatExpire { get; set; }

        [Display(Name = "Average Duration on Shelf")]
        [DisplayFormat(DataFormatString = "{0:dd\\.hh\\:mm\\:ss}")]
        public TimeSpan AverageSupplyDurationOnShelf { get; set; }

        // iBelong Baskets
        [Display(Name = "Total Shopping Lists")]
        public int TotalShoppingListBaskets { get; set; }

        [Display(Name = "Total Baskets")]
        public int TotaliBelongBaskets { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        [Display(Name = "Total Basket Price")]
        public decimal TotaliBelongBasketPrice { get; set; }

        [Display(Name = "Average Duration on Shelf")]
        [DisplayFormat(DataFormatString = "{0:dd\\.hh\\:mm\\:ss}")]
        public TimeSpan AverageBasketDurationOnShelf { get; set; }

        // Donors
        [Display(Name = "Top Donor By Number")]
        public Donor? TopDonorByNumberOfDonations { get; set; }
        public int TopNumberOfDonations { get; set; }
        
        [Display(Name = "Top Donor By Amount")]
        public Donor? TopDonorByDollarAmountDonated {  get; set; }

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        public decimal TopDollarAmountDonated { get; set; }

        // Recipient
        [Display(Name = "Top Recipient By Number")]
        public Recipient? TopRecipientByNumberOfItemsReceived { get; set; }
        public int TopNumberOfItemsReceived { get; set; }
        
        [Display(Name = "Top Recipient By Amount")]
        public Recipient? TopRecipientByDollarAmountReceived { get; set; }
        
        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        public decimal TopDollarAmountReceived { get; set; }
    }
}
