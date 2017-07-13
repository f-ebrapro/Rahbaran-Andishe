using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rahbaran_Andishe.Models;

namespace Rahbaran_Andishe.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        private SiteDb _db;
        public AdminController()
        {
            _db = new SiteDb();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Orders()
        {
            var model = _db.Forms.ToList();
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
                ViewBag.Danger = "لطفا موارد الزامی را وارد کنید";
                return View(model);
            }
            _db.Forms.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Orders");
        }
        public ActionResult Delete(int id)
        {
            var model = _db.Forms.Find(id);
            if (model == null)
            {
                ViewBag.Danger = "چنین کارمندی یافت نشد";
                return RedirectToAction("Orders");
            }
            _db.Forms.Remove(model);
            _db.SaveChanges();
            TempData["info"] = "حذف کارمند با موفقیت انجام شد";
            return RedirectToAction("Orders");
        }
        public ActionResult Details(int id)
        {
            var model = _db.Forms.Find(id);
            if (model == null)
            {
                //error namayesh bede gogooloo
                return RedirectToAction("Orders");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var model = _db.Forms.Find(id);
            if (model == null)
            {
                //error raise konid :)
                return RedirectToAction("Orders");
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Form model)
        {
            var Form = _db.Forms.Find(model.Id);

            if (Form == null)
            {
                //raise error please :D
                return RedirectToAction("Orders");
            }
            _db.Forms.Add(model);
            _db.SaveChanges();

            TempData["info"] = "کارمند با موفقیت ویرایش شد";
            return RedirectToAction("Orders");
        }
        public ActionResult Product()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Product(Form model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Danger = "لطفا موارد الزامی را وارد کنید";
                return View(model);
            }
            _db.Forms.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Orders");
        }
    }
}