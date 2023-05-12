using AspFinalProject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace AspFinalProject.Models.Contexts
{
    public class AppDbContext : IdentityDbContext<AccountEntity>
    {
        class ProductCategory
        {
            public ProductCategory(int categoriesId, int productsId)
            {
                CategoriesId = categoriesId;
                ProductsId = productsId;
            }

            public int CategoriesId { get; set; }
            public int ProductsId { get; set; }
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductEntity>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Products)
                .UsingEntity("ProductCategory");

            // Seed Roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "customer", NormalizedName = "CUSTOMER" }
            );

            // Seed Categories
            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, Name = "New" },
                new CategoryEntity { Id = 2, Name = "Featured" },
                new CategoryEntity { Id = 3, Name = "Popular" }
            );

            // Load Products from json
            var seedData = JArray.Parse(File.ReadAllText(@"Data\Products.json"));
            var products = new List<ProductEntity>();
            foreach (var item in seedData)
            {
                products.Add(item.ToObject<ProductEntity>()!);
            }

            // Seed Products
            builder.Entity<ProductEntity>().HasData(products);


            // Create CategoryProducts for seeding
            var categoryProducts = new List<ProductCategory>();
            for (var i = 1; i <= 3; i++)
            {
                for (var j = 1 + (i - 1) * 5; j <= 10 + (i - 1) * 5; j++)
                {
                    categoryProducts.Add(new ProductCategory(i, j));
                }
            }

            // Seed joined table: CategoryProduct
            builder.Entity("ProductCategory").HasData(categoryProducts);

        }
    }
}
