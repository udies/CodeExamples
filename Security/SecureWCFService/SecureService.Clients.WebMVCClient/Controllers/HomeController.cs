﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecureService.Clients.WebMVCClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["asdadskj"] = "hej";
            string hej = (string)Session["asdadskj"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}