using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Presentation.Models;
using Presentation.Models.Admin.Commerce.Products;

namespace Presentation.Controllers.Admin.Commerce.Products
{
    public class ProductsController : Controller
    {
        private DbInit db = new DbInit();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.ProductsT.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsModel productsModel = db.ProductsT.Find(id);
            if (productsModel == null)
            {
                return HttpNotFound();
            }
            return View(productsModel);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductsModelId,Nume,CodProdus,DescriereProdus,GreutateProdus,Pret,Producator,Categorie,IsActiv,MetaTitle,MetaKeywords,MetaDescription,Url")] ProductsModel productsModel)
        {
            if (ModelState.IsValid)
            {
                db.ProductsT.Add(productsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productsModel);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsModel productsModel = db.ProductsT.Find(id);
            if (productsModel == null)
            {
                return HttpNotFound();
            }
            return View(productsModel);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductsModelId,Nume,CodProdus,DescriereProdus,GreutateProdus,Pret,Producator,Categorie,IsActiv,MetaTitle,MetaKeywords,MetaDescription,Url")] ProductsModel productsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productsModel);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsModel productsModel = db.ProductsT.Find(id);
            if (productsModel == null)
            {
                return HttpNotFound();
            }
            return View(productsModel);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsModel productsModel = db.ProductsT.Find(id);
            db.ProductsT.Remove(productsModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
