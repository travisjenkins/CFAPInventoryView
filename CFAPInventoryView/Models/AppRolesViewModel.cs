using CFAPInventoryView.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Models
{
    public class AppRolesViewModel
    {
        public ApplicationUser? ApplicationUser { get; set; }

        [Display(Name = "Assigned Role")]
        public IList<string>? AssignedRoles { get; set; }
    }
}
