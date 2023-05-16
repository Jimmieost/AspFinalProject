using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

      

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModels = new List<UserRolesViewModel>();
            foreach (AccountEntity user in users)
            {
                var thisViewModel = new UserRolesViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.FirstName = user.FirstName;
                thisViewModel.LastName = user.LastName;
                thisViewModel.Roles = await GetUserRoles(user);
                userRolesViewModels.Add(thisViewModel);
            }
            return View(userRolesViewModels);
        }
        private async Task<List<string>> GetUserRoles(AccountEntity user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }





    }
}
