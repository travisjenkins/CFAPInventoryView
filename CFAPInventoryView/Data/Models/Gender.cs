﻿using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Gender
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid GenderId { get; set; }

        [Required]
        [StringLength(50)]
        public string? Description { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Modified By")]
        public string? LastUpdateId { get; set; }

        [Display(Name = "Last Modified")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yy, h:mm tt}")]
        public DateTime LastUpdateDateTime { get; set; }
    }
}
