using System.ComponentModel.DataAnnotations;

namespace CFAPInventoryView.Data.Models
{
    public class Contact
    {
        public Guid ContactId { get; set; }

        // user ID from AspNetUser table
        public string? OwnerId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
