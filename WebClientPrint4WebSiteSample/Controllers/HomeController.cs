﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebClientPrint4WebSiteSample.Models;

namespace WebClientPrint4WebSiteSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["WCPPDetectionScript"] = Neodynamic.SDK.Web.WebClientPrint.CreateWcppDetectionScript(Url.Action("ProcessRequest", "WebClientPrintAPI", null, Url.ActionContext.HttpContext.Request.Scheme), Url.ActionContext.HttpContext.Session.Id);

            return View();
        }


        public IActionResult Samples()
        {
            return View();
        }

        public IActionResult PrintersInfo()
        {
            ViewBag.WCPScript = Neodynamic.SDK.Web.WebClientPrint.CreateScript(Url.Action("ProcessRequest", "WebClientPrintAPI", null, Url.ActionContext.HttpContext.Request.Scheme), "", Url.ActionContext.HttpContext.Session.Id);

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
