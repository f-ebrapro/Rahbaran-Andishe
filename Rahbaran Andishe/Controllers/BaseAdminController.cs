using System.Web.Mvc;
using Rahbaran_Andishe.Models;
using WebApplication1.Infra.Keys;

namespace Rahbaran_Andishe.Controllers
{

    public class BaseAdminController : AsyncController
    {
        protected readonly SiteDb Db;


        public BaseAdminController()
        {
            Db = new SiteDb();
        }


        public void Success(string message = "عملیات با موفقیت انجام شد")
        {
            TempData[Constants.ColorKey] = "success";
            TempData[Constants.MessageKey] = message;
        }
        public void Info(string message )
        {
            TempData[Constants.ColorKey] = "info";
            TempData[Constants.MessageKey] = message;
        }
        public void Warning(string message) { 
            TempData[Constants.ColorKey] = "warning";
            TempData[Constants.MessageKey] = message;
        }
        public void NotFount(string message = "آیتمی یافت نشد")
        {
            TempData[Constants.ColorKey] = "warning";
            TempData[Constants.MessageKey] = message;
        }
        public void Danger(string message)
        {
            TempData[Constants.ColorKey] = "danegr";
            TempData[Constants.MessageKey] = message;
        }
    }
}