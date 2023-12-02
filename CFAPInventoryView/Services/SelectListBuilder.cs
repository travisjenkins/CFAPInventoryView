using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Linq;

namespace CFAPInventoryView.Services
{
    public static class SelectListBuilder
    {
        public static async Task<SelectList?> GetAgeGroupsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.AgeGroups.OrderBy(ag => ag.SortOrder).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(AgeGroup.AgeGroupId), nameof(AgeGroup.Description), selectedOption);
        }

        public static async Task<SelectList?> GetEthnicitiesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Ethnicities.OrderBy(e => e.Description).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Ethnicity.EthnicityId), nameof(Ethnicity.Description), selectedOption);
        }

        public static async Task<SelectList?> GetGendersSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Genders.OrderBy(g => g.Description).ToListAsync();
            if ( query is null) return null;
            return new SelectList(query, nameof(Gender.GenderId), nameof(Gender.Description), selectedOption);
        }

        public static async Task<SelectList?> GetCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Categories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Category.CategoryId), nameof(Category.Name), selectedOption);
        }

        public static async Task<SelectList?> GetOptionalCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.OptionalCategories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(OptionalCategory.OptionalCategoryId), nameof(OptionalCategory.Name), selectedOption);
        }

        public static async Task<SelectList?> GetExcludeCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.ExcludeCategories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(ExcludeCategory.ExcludeCategoryId), nameof(ExcludeCategory.Name), selectedOption);
        }

        public static async Task<SelectList?> GetDonorsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Donors.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Donor.DonorId), nameof(Donor.FullName), selectedOption);
        }

        public static async Task<SelectList?> GetRecipientsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Recipients.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Recipient.RecipientId), nameof(Recipient.FullName), selectedOption);
        }

        public static async Task<SelectList?> GetBasketsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Baskets.Where(b => !b.IsShoppingListItem).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Basket.BasketId), nameof(Basket.BasketDisplayName), selectedOption);
        }

        public static async Task<SelectList?> GetSuppliesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Supplies.OrderBy(p => p.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(Supply.SupplyId), nameof(Supply.Name), selectedOption);
        }

        public static async Task<SelectList?> GetStorageLocationsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.StorageLocations.OrderBy(s => s.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, nameof(StorageLocation.StorageLocationId), nameof(StorageLocation.Name), selectedOption);
        }

        public static IEnumerable<SelectListItem>? GetStatesSelectList(string? stateName = null)
        {
            IEnumerable<SelectListItem>? query = null;
            var statesList = HelperMethods.GetUSStatesList();
            if (!string.IsNullOrEmpty(stateName))
            {
                query = statesList.Select(s => new SelectListItem
                {
                    Text = s,
                    Value = s,
                    Selected = s.Contains(stateName)
                });
            }
            else
            {
                query = statesList.Select(s => new SelectListItem
                {
                    Text = s,
                    Value = s
                });
            }
            return query;
        }
    }
}
