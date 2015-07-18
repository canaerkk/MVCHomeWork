using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomeWork.Models;

namespace MVCHomeWork.Controllers
{
    public abstract class BaseController : Controller
    {
        protected 客戶資料Entities db = new 客戶資料Entities();

    }
}