using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
