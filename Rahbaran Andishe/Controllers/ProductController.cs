using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rahbaran_Andishe.Models;

namespace Rahbaran_Andishe.Controllers
{
    public class ProductController : BaseAdminController
    {
        // GET: Product
        public ActionResult Index()
        {
            var model = Db.Forms.ToList();
            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Form model, HttpPostedFileBase img)
        {
            var dbase = new SiteDb();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Db.Forms.Add(model);
            Db.SaveChanges();
            Success("عملیات درج با موفقیت انجام شد");
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = Db.Forms.Find(id);

            if (model == null)
            {
                NotFount();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Form product, HttpPostedFileBase img)  
        {
            var model = Db.Forms.Find(product.Id);

            if (model == null)
            {
                NotFount();
                return RedirectToAction("Index");
            }

            Db.SaveChanges();
            Success();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var model = Db.Forms.Find(id);

            Db.Forms.Remove(model);
            Db.SaveChanges();
            Success();
            return RedirectToAction("Index");
        }
    }
}