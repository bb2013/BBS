using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Presentation.Models.Admin.Commerce.Categories;

namespace Presentation.ViewModel.Admin.Commerce.Categories
{
    public class CategoriesViewModel
    {
        public int CategoriesModelId { get; set; }
        public string Nume { get; set; }
        public CategoriesViewModel Parent { get; set; }
        public int? ParentId { get; set; }
        public int Order { get; set; }
        public virtual List<CategoriesViewModel> Children { get; set; }
    }
}