using CFAPInventoryView.Controllers;
using CFAPInventoryView.Data.Models;

namespace CFAPInventoryView.Models
{
    public class RestockViewModel
    {
#pragma warning disable CS8618
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<OptionalCategory> OptionalCategories { get; set; }
#pragma warning restore CS8618
    }
}
