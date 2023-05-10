using AspFinalProject.Models.Contexts;
using AspFinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productRepository.GetAllProducts();

            

            return View(products);
        }


        public async Task<IActionResult> Details(int id)
        {
            var product = await productRepository.GetProductById(id);
            return View(product);
        }
    }
}
