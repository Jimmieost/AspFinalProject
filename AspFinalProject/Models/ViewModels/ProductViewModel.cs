using AspFinalProject.Models.Entities;

namespace AspFinalProject.Models.ViewModels
{


    public class ProductViewModel {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
        public List<CategoryViewModel> Categories { get; set; } = null!;
    }

}
