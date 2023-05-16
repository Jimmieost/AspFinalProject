using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspFinalProject.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly UserManager<AccountEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesController(UserManager<AccountEntity> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        
    }
}
