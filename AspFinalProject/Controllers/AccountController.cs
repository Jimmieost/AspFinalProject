using AspFinalProject.Models.ViewModels;
using AspFinalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspFinalProject.Controllers
{

    public class AccountController : Controller
    {
        private readonly AuthenticationService _auth;

        public AccountController(AuthenticationService auth)
        {
            _auth = auth;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.UserAldredyExistsAsync(viewModel))
                    ModelState.AddModelError("", "This email does already exist.");

                if (await _auth.RegisterUserAsync(viewModel))
                    return RedirectToAction("Index");


            }

            return View(viewModel);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel viewModel)

        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
