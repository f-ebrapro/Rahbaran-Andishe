using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rahbaran_Andishe.Models;

namespace Rahbaran_Andishe.Controllers
{
    public class SliderController : BaseAdminController
    {
        // GET: Slider
        public ActionResult Index()
        {
            var model = Db.Sliders.ToList();
            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Slider model, HttpPostedFileBase img)
        {
            if (!ModelState.IsValid)
            {
                Danger("لطفا ورودی ها را چک کنید");
                return View(model);
            }
            if (img.ContentLength <= 0)
            {
                Danger("فایل آپلود شده معتبر نمیباشد");
            }

            var name = img.FileName;
            var guid = Guid.NewGuid();
            var newName = $"{guid}-{name}";

            var path = Path.Combine(Server.MapPath("~/Storage"), newName);
            img.SaveAs(path);
            Success();
            model.Img = newName;
            Db.Sliders.Add(model);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var model = Db.Sliders.Find(id);

            if (model == null)
            {
                NotFount();
                return RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Slider model, HttpPostedFileBase img)
        {
            var dbmodel = Db.Sliders.Find(model.Id);

            if (dbmodel == null)
            {
                NotFount("خطا متاسفانه چنین آیتمی پیدا نشد");
                return RedirectToAction("Index");
            }


            if (img != null)
            {
                var oldName = dbmodel.Img;

                var oldPath = Request.MapPath("~/Storage/" + oldName);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                var name = img.FileName;
                var guid = Guid.NewGuid();
                var newName = $"{guid}-{name}";

                var path = Path.Combine(Server.MapPath("~/Storage"), newName);
                img.SaveAs(path);
                Success();
                Db.SaveChanges();

            }

            dbmodel.Description = model.Description;


            Db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var dbmodel = Db.Sliders.Find(id);

            if (dbmodel == null)
            {
                NotFount("خطا متاسفانه چنین آیتمی پیدا نشد");
                return RedirectToAction("Index");
            }

            var fileName = dbmodel.Img;
            var oldPath = Request.MapPath("~/Storage/" + fileName);
            if (System.IO.File.Exists(oldPath))
            {
                System.IO.File.Delete(oldPath);
            }
            Db.Sliders.Remove(dbmodel);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}