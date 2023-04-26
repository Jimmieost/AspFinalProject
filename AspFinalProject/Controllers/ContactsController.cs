using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
