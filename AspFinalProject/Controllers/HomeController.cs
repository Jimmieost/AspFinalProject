using AspFinalProject.Models.ViewModels;
using AspFinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productRepository;

        public HomeController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productRepository.GetAllProducts();
            var newProducts = products
                .Where(x => x.Categories.Select(y => y.Name).Contains("New"))
                .ToList();

            var featuredProducts = products
                    .Where(x => x.Categories.Select(y => y.Name).Contains("Featured"))
                    .ToList();

            var popularProducts = products
                    .Where(x => x.Categories.Select(y => y.Name).Contains("Popular"))
                    .ToList();
            
            var homeViewModel = new HomeViewModel
            {
                FeaturedProducts = featuredProducts,
                NewProducts = newProducts,
                PopularProducts = popularProducts
            };

            return View(homeViewModel);
        }
    }
}
