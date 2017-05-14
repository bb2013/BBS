using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Presentation.Models;
using Presentation.Models.Admin.Commerce.Categories;
using Presentation.ViewModel.Admin.Commerce.Categories;

namespace Presentation.Controllers.Admin.Commerce
{
    public class CommerceController : Controller
    {
        
        // GET: Commerce
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get()
        {
            List<CategoriesModel> locations;
            List<CategoriesViewModel> records;
            using (DbInit context = new DbInit())
            {
                locations = context.CategoriesT.ToList();

                records = locations.Where(l => l.ParentId == null).OrderBy(l => l.Order)
                    .Select(l => new CategoriesViewModel
                    {
                        CategoriesModelId = l.CategoriesModelId,
                        Nume = l.Nume,
                        Children = GetChildren(locations, l.CategoriesModelId)
                    }).ToList();
            }

            return Json(records, JsonRequestBehavior.AllowGet);
        }

        private List<CategoriesViewModel> GetChildren(List<CategoriesModel> locations, int parentId)
        {
            return locations.Where(l => l.ParentId == parentId).OrderBy(l => l.Order).Select(
                l => new CategoriesViewModel
                {
                    Nume = l.Nume,
                    Children = GetChildren(locations, l.CategoriesModelId)
                }).ToList();
        }
    }
}