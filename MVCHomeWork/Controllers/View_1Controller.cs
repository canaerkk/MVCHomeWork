﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCHomeWork.Models;

namespace MVCHomeWork.Controllers
{
    public class View_1Controller : BaseController
    {
        // GET: View_1
        public ActionResult Index()
        {
            return View();
        }
    }
}