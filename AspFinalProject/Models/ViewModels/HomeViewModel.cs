namespace AspFinalProject.Models.ViewModels
{
    public class HomeViewModel
    {
        public ProductViewModel Showcase { get; set; } = null!;
        public List<ProductViewModel> PopularProducts { get; set; } = null!;
        public List<ProductViewModel> FeaturedProducts { get; set; } = null!;
        public List<ProductViewModel> NewProducts { get; set; } = null!;
    }
}
