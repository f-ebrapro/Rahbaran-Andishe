using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rahbaran_Andishe.Models;

namespace Rahbaran_Andishe.Controllers
{
    public class HomeController : Controller
    {

        private readonly SiteDb _db;

        public HomeController()
        {
            _db = new SiteDb();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InternetMarketing()
        {
            return View();
        }

        public ActionResult FormPakage()
        {
            var dbase = new SiteDb();
            var query = dbase.CityCategories.ToList();
            ViewBag.CityCategories = query;
            var queryone = dbase.OtherfieldsCategories.ToList();
            ViewBag.OtherfieldsCategories = queryone;

                

            return View();
        }


        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewBag.Cities = _db.CityCategories.OrderBy(x => x.Title).ToList();
            ViewBag.OrderFileds = _db.OtherfieldsCategories.OrderBy(x => x.Title).ToList();


            base.OnActionExecuted(filterContext);
        }
    }
}