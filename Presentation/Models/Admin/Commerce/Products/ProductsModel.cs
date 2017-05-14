using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentation.Models.Admin.Commerce.Products
{
    [Table("Products")]
    public class ProductsModel
    {
        public int ProductsModelId { get; set; }
        public string Nume { get; set; }
        public string CodProdus { get; set; }
        public string DescriereProdus { get; set; }
        public string GreutateProdus { get; set; }
        public int Pret { get; set; }
        public string Producator { get; set; }
        public string Categorie { get; set; }
        public bool IsActiv { get; set; }
        //Seo Start
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string Url { get; set; }
        //Seo End

        public virtual ICollection<ProductsToCategoriesModel> ProductsToCategory { get; set; }
    }
}