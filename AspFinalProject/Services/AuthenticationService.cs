using AspFinalProject.Models.Entities;
using AspFinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AspFinalProject.Services
{
    public class AuthenticationService
    {

        private readonly UserManager<AccountEntity> _userManager;
        private readonly SignInManager<AccountEntity> _signInManager;

        public AuthenticationService(UserManager<AccountEntity> userManager, SignInManager<AccountEntity>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> UserAldredyExistsAsync(AccountRegisterViewModel viewModel)
        {
            return await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email);
        }

        public async Task<bool> RegisterUserAsync(AccountRegisterViewModel viewModel)
        {
            try
            {
                var accountEntity = new AccountEntity
                {
                    UserName = viewModel.Email,
                    Email = viewModel.Email,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName
                };

                var isFirstUser = !_userManager.Users.Any();
                var result = await _userManager.CreateAsync(accountEntity, viewModel.Password);

                if (result.Succeeded)
                {
                    if (isFirstUser)
                    {
                        await _userManager.AddToRoleAsync(accountEntity, "admin");
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(accountEntity, "customer");
                    }

                    return true;
                }
                else
                {
                    // Fel uppstod vid skapandet av användaren
                    // Du kan undersöka result.Errors för att få mer information om felet
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> LoginAsync(AccountLoginViewModel viewModel)
        {
            var accountEntity = await _signInManager.UserManager.FindByEmailAsync(viewModel.Email);

            if (accountEntity != null)
            {
               var result = await _signInManager.PasswordSignInAsync(accountEntity, viewModel.Password, false, lockoutOnFailure: false);
                return result.Succeeded;
            }

            return false;
        }


    }

}

