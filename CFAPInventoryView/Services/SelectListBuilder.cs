using CFAPInventoryView.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Services
{
    public static class SelectListBuilder
    {
        public static async Task<SelectList?> GetAgeGroupsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.AgeGroups.OrderBy(ag => ag.SortOrder).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "AgeGroupId", "Description", selectedOption);
        }

        public static async Task<SelectList?> GetEthnicitiesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Ethnicities.OrderBy(e => e.Description).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "EthnicityId", "Description", selectedOption);
        }

        public static async Task<SelectList?> GetGendersSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Genders.OrderBy(g => g.Description).ToListAsync();
            if ( query is null) return null;
            return new SelectList(query, "GenderId", "Description", selectedOption);
        }

        public static async Task<SelectList?> GetCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.Categories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "CategoryId", "Name", selectedOption);
        }

        public static async Task<SelectList?> GetOptionalCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.OptionalCategories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "OptionalCategoryId", "Name", selectedOption);
        }

        public static async Task<SelectList?> GetExcludeCategoriesSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.ExcludeCategories.OrderBy(c => c.Name).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "ExcludeCategoryId", "Name", selectedOption);
        }
    }
}
