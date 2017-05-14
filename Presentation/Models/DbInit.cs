using System.Data.Entity;
using Presentation.Models.Admin.Commerce.Categories;
using Presentation.Models.Admin.Commerce.Products;

namespace Presentation.Models
{
    public class DbInit : DbContext
    {
        public DbInit() : base("BBS"){}
        public DbSet<CategoriesModel> CategoriesT { get; set; }
        public DbSet<ProductsModel> ProductsT { get; set; }
        public DbSet<ProductsToCategoriesModel> ProductsToCategoriesModel { get; set; }
    }
}