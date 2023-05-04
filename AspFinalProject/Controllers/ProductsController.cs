using AspFinalProject.Models.Contexts;
using AspFinalProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspFinalProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductEntity> products = await _context.Products.ToListAsync();

            // Skapa viewmodel istället för entity??

            return View(products);
        }


        public IActionResult Details(string id)
        {
            return View();
        }
    }
}
