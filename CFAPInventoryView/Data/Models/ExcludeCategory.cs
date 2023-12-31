﻿using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class ExcludeCategory
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ExcludeCategoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }

        public ICollection<AgeGroupCategory> AgeGroups { get; set; } = new List<AgeGroupCategory>();
    }
}
