using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace AspFinalProject.Models.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } = null!; 

        public ICollection<ProductEntity> Products { get; set; } = null!;

    }
}
