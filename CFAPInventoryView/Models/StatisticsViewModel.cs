﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Models
{
    public class StatisticsViewModel
    {
        // Products
        [Display(Name = "Total Products")]
        public int TotalProducts { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        [Display(Name = "Total Inventory Price")]
        public decimal TotalInventoryPrice { get; set; }

        [Display(Name = "Total Perishable")]
        public int TotalItemsThatExpire { get; set; }

        [Display(Name = "Duration on Shelf")]
        [DisplayFormat(DataFormatString = "{0:dd\\.hh\\:mm\\:ss}")]
        public TimeSpan TotalProductDurationOnShelf { get; set; }

        // iBelong Baskets
        [Display(Name = "Total iBelong Shopping Lists")]
        public int TotalShoppingListBaskets { get; set; }

        [Display(Name = "Total iBelong Baskets")]
        public int TotaliBelongBaskets { get; set; }

        [DataType(DataType.Currency)]
        [Precision(13, 4)]
        [Display(Name = "Total iBelong Basket Price")]
        public decimal TotaliBelongBasketPrice { get; set; }

        [Display(Name = "Duration on Shelf")]
        [DisplayFormat(DataFormatString = "{0:dd\\.hh\\:mm\\:ss}")]
        public TimeSpan TotalBasketDurationOnShelf { get; set; }
    }
}
