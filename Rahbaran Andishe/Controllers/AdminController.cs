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
    }
}