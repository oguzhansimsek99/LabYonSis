﻿using LabaratuvarYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabaratuvarYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context(); 
        public ActionResult Index()
        {
            var a = db.Birim.ToList();
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