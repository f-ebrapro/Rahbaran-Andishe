using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rahbaran_Andishe.Controllers
{
    public class UploadController : BaseAdminController
    {
        // GET: Upload
        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file.ContentLength <= 0)
            {
                // return error
            }

            if (file.ContentType != "img/jpg")
            {
                // error
            }

            var name = file.FileName;
            var guid = Guid.NewGuid();
            var newName = $"{guid}-{name}";

            var path = Path.Combine(Server.MapPath("~/Storage"), newName);
            file.SaveAs(path);
            Success();
            return Content(newName);

        }
    }
}