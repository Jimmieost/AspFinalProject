using Microsoft.EntityFrameworkCore;
using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace AspFinalProject.Services
{
    public class AuthenticationService
    {

        private readonly UserManager <AccountEntity> _userManager;

        public AuthenticationService(UserManager<AccountEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> UserAldredyExistsAsync(AccountRegisterViewModel viewModel)
        {
            return await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email);
        }
        

        public async Task<bool> RegisterUserAsync(AccountRegisterViewModel viewModel)
        {

           AccountEntity accountEntity = viewModel;

            var result = await _userManager.CreateAsync(accountEntity, viewModel.Password);
            return result.Succeeded;

            
            
        }
            



        
    }
}
