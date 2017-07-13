using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;
using Rahbaran_Andishe.Models;

namespace Rahbaran_Andishe.Controllers
{

    public class AdminIMController : BaseAdminController
    {
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
        public ActionResult Add(Form model)
        {
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

            //var m2 = Db.Products.Single(x => x.Id == id);

            if (model == null)
            {
                NotFount();
                return RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Form product)
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

            if (model == null)
            {
                NotFount();
                return RedirectToAction("Index");
            }

            Db.Forms.Remove(model);
            Db.SaveChanges();
            Success();
            return RedirectToAction("Index");
        }
    }
}
