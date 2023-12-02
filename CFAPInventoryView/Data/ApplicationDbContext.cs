using CFAPInventoryView.Data.Extensions;
using CFAPInventoryView.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Overriding this method is necessary to seed data into the database when created
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<AgeGroup> AgeGroups { get; set; }
        public DbSet<Ethnicity> Ethnicities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OptionalCategory> OptionalCategories { get; set; }
        public DbSet<ExcludeCategory> ExcludeCategories { get; set; }
        public DbSet<AgeGroupCategory> AgeGroupCategories { get; set; }
        public DbSet<StorageLocation> StorageLocations { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<SupplyBasket> SupplyBaskets { get; set; }
        public DbSet<CategoryBasket> CategoryBaskets { get; set; }
        public DbSet<SupplyTransaction> SupplyTransactions { get; set; }
        public DbSet<BasketTransaction> BasketTransactions { get; set; }
    }
}