using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspFinalProject.Models.Entities
{
    public class AccountEntity : IdentityUser
    {
       
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        

        
    }
}
