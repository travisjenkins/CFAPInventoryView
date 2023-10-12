using CFAPInventoryView.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Models
{
    public class UserManagementViewModel
    {
        public ApplicationUser? ApplicationUser { get; set; }

        [Display(Name = "Locked Out?")]
        public bool IsLockedOut { get; set; }

        [Display(Name = "Lockout End Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy, hh:mm tt}")]
        public DateTime? LockoutEndDate { get; set; }
    }
}
