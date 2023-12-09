using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Extensions;
using CFAPInventoryView.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using SQLitePCL;
using System.Reflection;
using System.Text.Json;

namespace CFAPInventoryView
{
    public static class HelperMethods
    {
        public const string AdministratorRole = "Administrator";
        public const string ManagerRole = "Manager";
        public const string MemberRole = "Member";
        public const string RegisteredUser = "RegisteredUser";

        public static async Task<List<Supply>?> GetAllAvailableSupplies(ApplicationDbContext context, Guid? selectedAgeGroupId = null)
        {
            // Get all categories that apply to the selected age group.
            List<Category> allCategories = await HelperMethods.GetCategoriesForAgeGroup(context, selectedAgeGroupId);
            var categoryIds = new HashSet<Guid>(allCategories.Select(c => c.CategoryId));
            List<OptionalCategory> allOptionalCategories = await HelperMethods.GetOptionalCategoriesForAgeGroup(context, selectedAgeGroupId);
            var optionalCategoryIds = new HashSet<Guid>(allOptionalCategories.Select(c => c.OptionalCategoryId));
            // Get all supplies that are assigned to one of the categories that apply to the selected age group.
            var allSupplies = await context.Supplies.AsNoTracking()
                .Where(p => p.Active && p.CategoryId != null && categoryIds.Contains((Guid)p.CategoryId) ||
                            p.Active && p.OptionalCategoryId != null && optionalCategoryIds.Contains((Guid)p.OptionalCategoryId))
                .OrderBy(p => p.Name)
                .ToListAsync();
            return allSupplies;
        }

        public static async Task<List<ExcludeCategory>> GetExcludeCategoriesForAgeGroup(ApplicationDbContext context, Guid? selectedAgeGroupId)
        {
            List<ExcludeCategory> allExcludeCategories = new();
            if (selectedAgeGroupId.HasValue)
            {
                var excludeCategoryIds = await context.AgeGroupCategories.AsNoTracking().Where(agc => agc.AgeGroupId == selectedAgeGroupId.Value).Select(agc => agc.ExcludeCategoryId).ToListAsync();
                if (excludeCategoryIds is not null)
                {
                    foreach (var id in excludeCategoryIds)
                    {
                        if (id.HasValue)
                        {
                            allExcludeCategories.Add(await context.ExcludeCategories.AsNoTracking().Where(ec => ec.ExcludeCategoryId == id).FirstAsync());
                        }
                    }
                }
                else
                {
                    allExcludeCategories = await context.ExcludeCategories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
                }
            }
            else
            {
                allExcludeCategories = await context.ExcludeCategories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
            }

            return allExcludeCategories;
        }

        public static async Task<List<OptionalCategory>> GetOptionalCategoriesForAgeGroup(ApplicationDbContext context, Guid? selectedAgeGroupId)
        {
            List<OptionalCategory> allOptionalCategories = new();
            if (selectedAgeGroupId.HasValue)
            {
                var optionalCategoryIds = await context.AgeGroupCategories.AsNoTracking().Where(agc => agc.AgeGroupId == selectedAgeGroupId.Value).Select(agc => agc.OptionalCategoryId).ToListAsync();
                if (optionalCategoryIds is not null)
                {
                    foreach (var id in optionalCategoryIds)
                    {
                        if (id.HasValue)
                        {
                            allOptionalCategories.Add(await context.OptionalCategories.AsNoTracking().Where(oc => oc.OptionalCategoryId == id).FirstAsync());
                        }
                    }
                }
                else
                {
                    allOptionalCategories = await context.OptionalCategories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
                }
            }
            else
            {
                allOptionalCategories = await context.OptionalCategories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
            }

            return allOptionalCategories;
        }

        public static async Task<List<Category>> GetCategoriesForAgeGroup(ApplicationDbContext context, Guid? selectedAgeGroupId)
        {
            List<Category> allCategories = new();
            if (selectedAgeGroupId.HasValue)
            {
                var categoryIds = await context.AgeGroupCategories.AsNoTracking().Where(agc => agc.AgeGroupId == selectedAgeGroupId.Value).Select(agc => agc.CategoryId).ToListAsync();
                if (categoryIds is not null)
                {
                    foreach (var id in categoryIds)
                    {
                        if (id.HasValue)
                        {
                            allCategories.Add(await context.Categories.AsNoTracking().Where(c => c.CategoryId == id).FirstAsync());
                        }
                    }
                }
                else
                {
                    allCategories = await context.Categories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
                }
            }
            else
            {
                allCategories = await context.Categories.AsNoTracking().OrderBy(c => c.Name).ToListAsync();
            }

            return allCategories;
        }

        public static async Task IncreaseAssignedCategoryQuantity(ApplicationDbContext context, Supply supply)
        {
            if (supply.CategoryId is not null)
            {
                var category = await context.Categories.FindAsync(supply.CategoryId) ?? throw new DbUpdateException($"A category could not be found in the database with ID {supply.CategoryId}");
                category.Quantity += supply.Quantity;
                context.Update(category);
            }
            if (supply.OptionalCategoryId is not null)
            {
                var optionalCategory = await context.OptionalCategories.FindAsync(supply.OptionalCategoryId) ?? throw new DbUpdateException($"An optional category could not be found in the database with ID {supply.OptionalCategoryId}");
                optionalCategory.Quantity += supply.Quantity;
                context.Update(optionalCategory);
            }
            if (supply.ExcludeCategory is not null)
            {
                var excludeCategory = await context.ExcludeCategories.FindAsync(supply.ExcludeCategoryId) ?? throw new DbUpdateException($"An exclude category could not be found in the database with ID {supply.ExcludeCategoryId}");
                excludeCategory.Quantity += supply.Quantity;
                context.Update(excludeCategory);
            }
        }
        public static async Task IncreaseAssignedCategoryQuantityByOne(ApplicationDbContext context, Supply supply)
        {
            if (supply.CategoryId is not null)
            {
                var category = await context.Categories.FindAsync(supply.CategoryId) ?? throw new DbUpdateException($"A category could not be found in the database with ID {supply.CategoryId}");
                category.Quantity += 1;
                context.Update(category);
            }
            if (supply.OptionalCategoryId is not null)
            {
                var optionalCategory = await context.OptionalCategories.FindAsync(supply.OptionalCategoryId) ?? throw new DbUpdateException($"An optional category could not be found in the database with ID {supply.OptionalCategoryId}");
                optionalCategory.Quantity += 1;
                context.Update(optionalCategory);
            }
            if (supply.ExcludeCategory is not null)
            {
                var excludeCategory = await context.ExcludeCategories.FindAsync(supply.ExcludeCategoryId) ?? throw new DbUpdateException($"An exclude category could not be found in the database with ID {supply.ExcludeCategoryId}");
                excludeCategory.Quantity += 1;
                context.Update(excludeCategory);
            }
        }

        public static async Task DecreaseAssignedCategoryQuantity(ApplicationDbContext context, Supply supply)
        {
            if (supply.CategoryId is not null)
            {
                var category = await context.Categories.FindAsync(supply.CategoryId) ?? throw new DbUpdateException($"A category could not be found in the database with ID {supply.CategoryId}");
                if ((category.Quantity - supply.Quantity) >= 0)
                {
                    category.Quantity -= supply.Quantity;
                    context.Update(category);
                }
            }
            if (supply.OptionalCategoryId is not null)
            {
                var optionalCategory = await context.OptionalCategories.FindAsync(supply.OptionalCategoryId) ?? throw new DbUpdateException($"An optional category could not be found in the database with ID {supply.OptionalCategoryId}");
                if ((optionalCategory.Quantity - supply.Quantity) >= 0)
                {
                    optionalCategory.Quantity -= supply.Quantity;
                    context.Update(optionalCategory);
                }
            }
            if (supply.ExcludeCategory is not null)
            {
                var excludeCategory = await context.ExcludeCategories.FindAsync(supply.ExcludeCategoryId) ?? throw new DbUpdateException($"An exclude category could not be found in the database with ID {supply.ExcludeCategoryId}");
                if ((excludeCategory.Quantity - supply.Quantity) >= 0)
                {
                    excludeCategory.Quantity -= supply.Quantity;
                    context.Update(excludeCategory);
                }
            }
        }

        public static async Task DecreaseAssignedCategoryQuantityByOne(ApplicationDbContext context, Supply supply)
        {
            if (supply.CategoryId is not null)
            {
                var category = await context.Categories.FindAsync(supply.CategoryId) ?? throw new DbUpdateException($"A category could not be found in the database with ID {supply.CategoryId}");
                if (category.Quantity > 0)
                {
                    category.Quantity -= 1;
                    context.Update(category);
                }
            }
            if (supply.OptionalCategoryId is not null)
            {
                var optionalCategory = await context.OptionalCategories.FindAsync(supply.OptionalCategoryId) ?? throw new DbUpdateException($"An optional category could not be found in the database with ID {supply.OptionalCategoryId}");
                if (optionalCategory.Quantity > 0)
                {
                    optionalCategory.Quantity -= 1;
                    context.Update(optionalCategory);
                }
            }
            if (supply.ExcludeCategory is not null)
            {
                var excludeCategory = await context.ExcludeCategories.FindAsync(supply.ExcludeCategoryId) ?? throw new DbUpdateException($"An exclude category could not be found in the database with ID {supply.ExcludeCategoryId}");
                if (excludeCategory.Quantity > 0)
                {
                    excludeCategory.Quantity -= 1;
                    context.Update(excludeCategory);
                }
            }
        }

        public static async Task UpdateAssignedCategoryQuantity(ApplicationDbContext context, Supply supplyToUpdate)
        {
            // Get the current product to evaluate if the quantity increased or decreased
            var currentSupply = await context.Supplies.AsNoTracking().FirstOrDefaultAsync(s => s.SupplyId == supplyToUpdate.SupplyId) ?? throw new DbUpdateException($"A product could not be found in the database with ID {supplyToUpdate.SupplyId}");
            // Increase
            if (currentSupply.Quantity < supplyToUpdate.Quantity)
            {
                await IncreaseAssignedCategoryQuantity(context, supplyToUpdate);
            }
            // Decrease
            else if (currentSupply.Quantity > supplyToUpdate.Quantity)
            {
                await DecreaseAssignedCategoryQuantity(context, supplyToUpdate);
            }
        }

        public static async Task<List<AssignedAgeGroupViewModel>> PopulateAssignedAgeGroups<T>(ApplicationDbContext context, T category)
        {
            HashSet<Guid>? assignedAgeGroupIds = null;
            if (category is Category)
            {
                Category? cat = category as Category;
                if (cat is not null)
                {
                    cat.AgeGroups ??= new List<AgeGroupCategory>();
                    assignedAgeGroupIds = new HashSet<Guid>(cat.AgeGroups.Select(a => a.AgeGroupId));
                }
            }
            else if (category is OptionalCategory)
            {
                OptionalCategory? optionalCategory = category as OptionalCategory;
                if (optionalCategory is not null)
                {
                    optionalCategory.AgeGroups ??= new List<AgeGroupCategory>();
                    assignedAgeGroupIds = new HashSet<Guid>(optionalCategory.AgeGroups.Select(a => a.AgeGroupId));
                }
            }
            else if (category is ExcludeCategory) 
            {
                ExcludeCategory? excludeCategory = category as ExcludeCategory;
                if (excludeCategory is not null)
                {
                    excludeCategory.AgeGroups ??= new List<AgeGroupCategory>();
                    assignedAgeGroupIds = new HashSet<Guid>(excludeCategory.AgeGroups.Select(a => a.AgeGroupId));
                }
            }
            List<AssignedAgeGroupViewModel> assignedAgeGroupViewModels = new();
            var allAgeGroups = await context.AgeGroups.AsNoTracking().OrderBy(a => a.SortOrder).ToListAsync();
            if (allAgeGroups is not null)
            {
                if (assignedAgeGroupIds is not null)
                {
                    foreach (var ageGroup in allAgeGroups)
                    {
                        assignedAgeGroupViewModels.Add(new AssignedAgeGroupViewModel
                        {
                            AgeGroupId = ageGroup.AgeGroupId,
                            Description = ageGroup.Description,
                            Assigned = assignedAgeGroupIds.Contains(ageGroup.AgeGroupId)
                        });
                    }
                }
            }
            return assignedAgeGroupViewModels;
        }

        public static async Task AddAgeGroupsToCategory(ApplicationDbContext context, Guid categoryId, List<Guid>? selectedAgeGroupIds, string categoryType)
        {
            List<AgeGroupCategory> ageGroupCategories = new();
            switch (categoryType)
            {
                case nameof(Category):
                    ageGroupCategories = await context.AgeGroupCategories.Where(agc => agc.CategoryId == categoryId).ToListAsync();
                    break;
                case nameof(OptionalCategory):
                    ageGroupCategories = await context.AgeGroupCategories.Where(agc => agc.OptionalCategoryId == categoryId).ToListAsync();
                    break;
                case nameof(ExcludeCategory):
                    ageGroupCategories = await context.AgeGroupCategories.Where(agc => agc.ExcludeCategoryId == categoryId).ToListAsync();
                    break;
                default:
                    break;
            }
            List<AgeGroupCategory> ageGroupCategoriesToAdd = new();
            if (selectedAgeGroupIds is not null)
            {
                foreach (var ageGroupId in selectedAgeGroupIds)
                {
                    if (!ageGroupCategories.Any(agc => agc.AgeGroupId == ageGroupId))
                    {
                        
                        var ageGroupToAdd = new AgeGroupCategory
                        {
                            AgeGroupCategoryId = Guid.NewGuid(),
                            AgeGroupId = ageGroupId
                        };
                        switch (categoryType)
                        {
                            case nameof(Category):
                                ageGroupToAdd.CategoryId = categoryId;
                                break;
                            case nameof(OptionalCategory):
                                ageGroupToAdd.OptionalCategoryId = categoryId;
                                break;
                            case nameof(ExcludeCategory):
                                ageGroupToAdd.ExcludeCategoryId = categoryId;
                                break;
                            default:
                                break;
                        }
                        ageGroupCategoriesToAdd.Add(ageGroupToAdd);
                    }
                }
            }
            if (ageGroupCategoriesToAdd.Count > 0)
            {
                await context.AgeGroupCategories.AddRangeAsync(ageGroupCategoriesToAdd);
                await context.SaveChangesAsync();
            }
        }

        public static async Task EditAgeGroupsForCategory(ApplicationDbContext context, Guid id, List<Guid>? selectedAgeGroupIds, string categoryType)
        {
            // 1. Get current assigned age groups
            List<AgeGroupCategory>? currentAssignedAgeGroups = new();
            if (categoryType == nameof(Category))
                currentAssignedAgeGroups.AddRange(await context.AgeGroupCategories.Where(agc => agc.CategoryId == id).ToListAsync());
            else if (categoryType == nameof(OptionalCategory))
                currentAssignedAgeGroups.AddRange(await context.AgeGroupCategories.Where(agc => agc.OptionalCategoryId == id).ToListAsync());
            else if (categoryType == nameof(ExcludeCategory))
                currentAssignedAgeGroups.AddRange(await context.AgeGroupCategories.Where(agc => agc.ExcludeCategoryId == id).ToListAsync());
            

            if (selectedAgeGroupIds is null || selectedAgeGroupIds.Count == 0)
            {
                await DeleteAgeGroupsFromCategory(context, categoryType, id);  // 2. If null delete all assigned
            }
            else
            {
                // 3. Get the Ids only
                var currentAssignedAgeGroupIds = currentAssignedAgeGroups.Select(agc => agc.AgeGroupId).ToList();
                // 4. Get the Ids to add
                var ageGroupsToAdd = selectedAgeGroupIds?.Where(id => !currentAssignedAgeGroupIds.Contains(id)).ToList();
                // 5. Get the Ids to delete
#pragma warning disable 8602
                var ageGroupsToDelete = currentAssignedAgeGroupIds.Where(id => !selectedAgeGroupIds.Contains(id)).ToList();
#pragma warning restore 8602
                // 6. Delete
                if (ageGroupsToDelete?.Count > 0)
                {
                    await DeleteAgeGroupsFromCategory(context, categoryType, id, currentAssignedAgeGroups, ageGroupsToDelete);
                }
                // 7. Add
                if (ageGroupsToAdd?.Count > 0)
                {
                    await AddAgeGroupsToCategory(context, id, selectedAgeGroupIds, categoryType);
                }
                // 8. If there ere no products to add or remove ensure other changes are saved to the database.
                if (ageGroupsToDelete?.Count is null || ageGroupsToDelete?.Count == 0 && ageGroupsToAdd?.Count is null || ageGroupsToAdd?.Count == 0)
                {
                    await context.SaveChangesAsync();
                }
            }
        }

        public static async Task DeleteAgeGroupsFromCategory(ApplicationDbContext context, string categoryType, Guid id, List<AgeGroupCategory>? assignedAgeGroups = null, List<Guid>? ageGroupIdsToDelete = null)
        {
            List<AgeGroupCategory>? ageGroupCategoriesToDelete = null;
            if (assignedAgeGroups is null)
            {
                if (categoryType == nameof(Category))
                    ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.CategoryId == id).ToListAsync();
                else if (categoryType == nameof(OptionalCategory))
                    ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.OptionalCategoryId == id).ToListAsync();
                else if (categoryType == nameof(ExcludeCategory))
                    ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.ExcludeCategoryId == id).ToListAsync();
            }
            if (ageGroupIdsToDelete is not null && ageGroupIdsToDelete.Count > 0)
            {
                var ageGroupIds = new HashSet<Guid>(ageGroupIdsToDelete);
                if (categoryType == nameof(Category))
                {
                    if (assignedAgeGroups is not null)
                    {
                        ageGroupCategoriesToDelete = assignedAgeGroups.Where(agc => agc.CategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToList();
                    }
                    else
                    {
                        ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.CategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToListAsync();
                    }
                }
                else if (categoryType == nameof(OptionalCategory))
                {
                    if (assignedAgeGroups is not null)
                    {
                        ageGroupCategoriesToDelete = assignedAgeGroups.Where(agc => agc.OptionalCategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToList();
                    }
                    else
                    {
                        ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.OptionalCategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToListAsync();
                    }
                }
                else if (categoryType == nameof(ExcludeCategory))
                {
                    if (assignedAgeGroups is not null)
                    {
                        ageGroupCategoriesToDelete = assignedAgeGroups.Where(agc => agc.ExcludeCategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToList();
                    }
                    else
                    {
                        ageGroupCategoriesToDelete = await context.AgeGroupCategories.Where(agc => agc.ExcludeCategoryId == id && ageGroupIds.Contains(agc.AgeGroupId)).ToListAsync();
                    }
                }
            }
            if (ageGroupCategoriesToDelete is not null && ageGroupCategoriesToDelete.Count > 0)
            {
                context.AgeGroupCategories.RemoveRange(ageGroupCategoriesToDelete);
                await context.SaveChangesAsync();
            }
        }

        public static string DisplaySafeString<T>(T displayString)
        {
            if (displayString is null) return string.Empty;

            if (displayString.GetType() == typeof(string))
            {
                return displayString as string ?? string.Empty;
            }
            if (displayString.GetType() == typeof(int))
            {
                return string.Format("{0:0}", displayString);
            }
            if (displayString.GetType() == typeof(double))
            {
                return string.Format("{0:0.0}", displayString);
            }
            if (displayString.GetType() == typeof(decimal))
            {
                return string.Format("{0:0.00}", displayString);
            }
            return displayString.ToString() ?? string.Empty;
        }

        public static DateTime? CombineDateAndTimeInputFields(DateTime? date, DateTime? time)
        {
            if (!date.HasValue && !time.HasValue) return null;
            if (!DateTime.TryParse(date?.ToShortDateString(), out DateTime propertyDate)) return null;
            if (!DateTime.TryParse(time?.ToShortTimeString(), out DateTime propertyTime)) return null;

            return new DateTime(propertyDate.Year, propertyDate.Month, propertyDate.Day, propertyTime.Hour, propertyTime.Minute, propertyTime.Second);
        }

        public static void UpdateEntityProperties<T1, T2>(T1 entityToUpdate, T2 entityWithUpdates)
        {
            if (entityToUpdate != null && entityWithUpdates != null)
            {
                foreach (PropertyInfo prop in entityWithUpdates.GetType().GetProperties())
                {
                    entityToUpdate.GetType().GetProperty(prop.Name)?.SetValue(entityToUpdate, prop.GetValue(entityWithUpdates));
                }
            }
        }

        public static async Task PrepareErrorsForTransfer(ModelStateDictionary modelState, ITempDataDictionary tempData)
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var dictionaryOfErrors = modelState.Where(s => s.Value.Errors.Any()).ToDictionary(m => m.Key, m => m.Value.Errors.Select(s => s.ErrorMessage).FirstOrDefault(s => s is not null));
#pragma warning restore CS8602 // Defreference of a possibly null reference

            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, dictionaryOfErrors);
            stream.Position = 0;

            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            tempData["ModelState"] = json;
        }

        public static void RetrieveTransferredErrors(ModelStateDictionary modelState, ITempDataDictionary tempData)
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var modelStateString = tempData["ModelState"].ToString();
#pragma warning restore CS8602 // Defreference of a possibly null reference
            if (!string.IsNullOrEmpty(modelStateString))
            {
                var dictionaryOfErrors = JsonSerializer.Deserialize<Dictionary<string, string?>>(modelStateString);
                if (dictionaryOfErrors is not null)
                {
                    foreach (var item in dictionaryOfErrors)
                    {
                        modelState.AddModelError(item.Key, item.Value ?? "");
                    }
                }
            }
        }

        private static readonly List<string> _USStateNames = new()
        {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "NewHampshire",
            "NewJersey",
            "NewMexico",
            "NewYork",
            "NorthCarolina",
            "NorthDakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "RhodeIsland",
            "SouthCarolina",
            "SouthDakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "WestVirginia",
            "Wisconsin",
            "Wyoming"
        };

        private static readonly List<string> _USStateAbbreviation = new()
        {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"
        };

        public static List<string> GetUSStatesList()
        {
            var usStateList = new List<string>();
            for (int i = 0; i < _USStateNames.Count; i++)
            {
                usStateList.Add($"{_USStateNames[i].SplitCamelAndPascalCase()} - {_USStateAbbreviation[i]}");
            }
            return usStateList;
        }

        public static string JustTheStateName(string? longName)
        {
            if (string.IsNullOrEmpty(longName)) return string.Empty;
            if (!longName.Contains(' ')) return string.Empty;
            return longName.Split(' ')[0];
        }
    }
}
