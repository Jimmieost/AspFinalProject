using System.ComponentModel.DataAnnotations;

namespace AspFinalProject.Models.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; } = null!;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; } = null!;
    }
}
