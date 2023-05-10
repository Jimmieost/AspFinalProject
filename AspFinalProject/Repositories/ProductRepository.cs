
using AspFinalProject.Models.Contexts;
using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AspFinalProject.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ProductViewModel>> GetAllProducts()
        {
            var productEntities = await dbContext
                .Products
                .Include(x => x.Categories)
                .ToListAsync();

            var result = new List<ProductViewModel>();
            foreach (var productEntity in productEntities)
            {
                var viewModel = MapToViewModel(productEntity);
                result.Add(viewModel);
            }
            return result;
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            var productEntity = await dbContext
                .Products
                .SingleAsync(x => x.Id == id);

            return MapToViewModel(productEntity);
        }


        private ProductViewModel MapToViewModel(ProductEntity productEntity) {
                return new ProductViewModel
                {
                    Description = productEntity.Description,
                    Id = productEntity.Id,
                    Image = productEntity.Image,
                    Name = productEntity.Name,
                    Price = productEntity.Price,
                    Categories = productEntity.Categories
                        .Select(categoryEntity => new CategoryViewModel
                        {
                            Name = categoryEntity.Name,
                            Id = categoryEntity.Id
                        }).ToList()
                };
        }
    }
}

