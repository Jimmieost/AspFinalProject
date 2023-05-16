﻿using AspFinalProject.Models.Entities;

namespace AspFinalProject.Models.ViewModels
{
    public class ProfileViewModel
    {
        public ProfileViewModel(AccountEntity entity)
        {
            FirstName = entity.FirstName;
            LastName = entity.LastName;
            Email = entity.Email;
        }

        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string? Email { get; set; }

    }

    
}
