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
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<ProductBasket> ProductBaskets { get; set; }
        public DbSet<CategoryBasket> CategoryBaskets { get; set; }
    }
}