using AspFinalProject.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspFinalProject.Models.Contexts
{
    public class AppDbContext : IdentityDbContext<AccountEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AccountEntity>Accounts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
               
        
            builder.Entity<ProductEntity>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Products)
                .UsingEntity("ProductCategory");
        
        }
    }
}
