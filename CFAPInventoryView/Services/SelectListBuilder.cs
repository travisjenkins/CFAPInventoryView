using CFAPInventoryView.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Services
{
    public static class SelectListBuilder
    {
        public static async Task<SelectList?> GetAgeGroupsSelectListAsync(ApplicationDbContext context, object? selectedOption = null)
        {
            var query = await context.AgeGroups.OrderBy(ag => ag.Group).ToListAsync();
            if (query is null) return null;
            return new SelectList(query, "AgeGroupId", "Group", selectedOption);
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
    }
}
