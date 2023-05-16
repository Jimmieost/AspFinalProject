using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspFinalProject.Controllers
{
    
    [Authorize(Roles = "admin")]
    
    public class AdminController : Controller
    {
        private readonly UserManager<AccountEntity> _userManager;

        public AdminController(UserManager<AccountEntity> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        
       




    }
}
