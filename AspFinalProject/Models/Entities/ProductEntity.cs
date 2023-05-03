using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspFinalProject.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; } 

        public ICollection<CategoryEntity> Categories { get; set; } = null!;

    }
}
