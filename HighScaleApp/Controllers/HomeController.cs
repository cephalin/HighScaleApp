﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighScaleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session.Add("visited", "true");
            return View();
        }

        [OutputCache(Duration = 60)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [OutputCache(Duration = 60)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}