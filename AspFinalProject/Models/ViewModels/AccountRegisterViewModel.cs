using AspFinalProject.Models.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspFinalProject.Models.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; } = null!;


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; } = null!;


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; } = null!;

        
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; } = null!;


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please confirm your password.")]
        public string PasswordConfirmed { get; set; } = null!;


        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;


        public static implicit operator AccountEntity(AccountRegisterViewModel viewModel)
        {
            return new AccountEntity
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,

            };
        }

    }
}
