using Presentation.Models.Admin.Commerce.Categories;

namespace Presentation.Models.Admin.Commerce.Products
{
    public class ProductsToCategoriesModel
    {
        public int ProductsToCategoriesModelId { get; set; }
        public int CategoriesModelId{ get; set; }
        public int ProductsModelId { get; set; }

        public CategoriesModel CategoriesModel { get; set; }
        public ProductsModel ProductsModel { get; set; }
    }
}