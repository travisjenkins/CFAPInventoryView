using CFAPInventoryView.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Models
{
    public class UserManagementViewModel
    {
        public ApplicationUser? ApplicationUser { get; set; }

        [Display(Name = "Last Login")]
        [DisplayFormat(DataFormatString = "{0: MMMM dd, yyyy, hh:mm tt}")]
        public DateTime? LastLogin { get; set; }

        [Display(Name = "Locked Out?")]
        public bool IsLockedOut { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Lockout End Date")]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime? LockoutEndDate { get; set; }
    }
}
