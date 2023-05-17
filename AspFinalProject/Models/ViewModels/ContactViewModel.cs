using System.ComponentModel.DataAnnotations;

namespace AspFinalProject.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;

    }
}
