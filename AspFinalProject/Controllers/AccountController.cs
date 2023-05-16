using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using AspFinalProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspFinalProject.Controllers
{

    public class AccountController : Controller
    {
        private readonly AuthenticationService _auth;
        private readonly UserManager<AccountEntity> _userManager;
        private readonly SignInManager<AccountEntity> _signInManager;

        public AccountController(AuthenticationService auth, UserManager<AccountEntity> userManager, SignInManager<AccountEntity> signInManager)
        {
            _auth = auth;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user is null)
                return View();
            return View(new ProfileViewModel(user));
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
                    return RedirectToAction("Login");


            }

            return View(viewModel);
        }

        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                if (await _auth.LoginAsync(viewModel))
                {
                    if (User.IsInRole("admin"))
                        return RedirectToAction("Index", "Admin"); // Omdirigera till adminsidan

                    else
                        return RedirectToAction("Index", "Account"); // Omdirigera till profilsidan för vanlig användare
                }

            }
            
            
                
                return View(viewModel);
        }


        public async Task<IActionResult> Logout()
        {
            if (_signInManager.IsSignedIn(User))
            {
                await _signInManager.SignOutAsync();
            }
            return LocalRedirect("/");

            

        }

        
            
    }

        
}

