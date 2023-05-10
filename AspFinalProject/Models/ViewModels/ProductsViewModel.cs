namespace AspFinalProject.Models.ViewModels
{
    public class ProductsViewModel
    {
        public List<ProductViewModel> NewProducts { get; set; } = null!;
        public List<ProductViewModel> FeaturedProducts { get; set; } = null!;
        public List<ProductViewModel> PopularProducts { get; set; } = null!;
    }
}
