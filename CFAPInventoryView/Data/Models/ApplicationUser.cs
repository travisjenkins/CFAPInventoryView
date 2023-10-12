using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    /*
     * Custom user class for better user information.
     * https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-7.0
     */
    public class ApplicationUser : IdentityUser
    {
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

        [PersonalData]
        [Display(Name = "Registered On")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy, hh:mm tt}")]
        public DateTime? RegisteredOn { get; set; }

        [PersonalData]
        [Display(Name = "Last Login")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy, hh:mm tt}")]
        public DateTime? LastLogin { get; set; }
    }
}
