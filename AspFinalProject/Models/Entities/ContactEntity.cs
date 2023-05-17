﻿namespace AspFinalProject.Models.Entities
{
    public class ContactEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
