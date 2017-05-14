using System.ComponentModel.DataAnnotations.Schema;

namespace Presentation.Models.Admin.Commerce.Categories
{
    [Table("Categories")]
    public class CategoriesModel
    {
        public int CategoriesModelId { get; set; }
        public string Nume { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }

        public CategoriesModel Parent { get; set; }
        public int? ParentId { get; set; }
        public int Order { get; set; }

        //Seo Start
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string Url { get; set; }
        //Seo End
    }
}