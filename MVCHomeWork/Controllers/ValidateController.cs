using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomeWork.Models;
using System.Linq;
using System.Data.Entity;

namespace MVCHomeWork.Controllers
{
    public class ValidateController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();
        
        public JsonResult CheckEmail(string Email, int 客戶Id)
        {
            bool isValidate = true;
            if (Url.IsLocalUrl(Request.Url.AbsolutePath))
            {
                var 客戶聯絡人 = db.客戶聯絡人;
                var query = (from p in 客戶聯絡人
                             where p.Email == Email && p.客戶Id == 客戶Id
                             select p).Count();
                
                if (query>=1)
                {
                    isValidate = false;
                }
                else
                {
                    isValidate = true;
                }
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
        
    }
}