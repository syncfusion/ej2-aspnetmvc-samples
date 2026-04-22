#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: AreaZone
        public ActionResult AreaZone()
        {
           ViewData["content"] = "<div style='width:80px; padding: 5px;'> <table style='width: 100%'>" +
    "<tr><td><div style='width: 10px; height: 10px;background:linear-gradient(#4ca1af, #c4e0e5);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Winter</td></tr>" +
    "<tr><td><div style='width: 10px; height: 10px; background:linear-gradient(#ffa751, #ffe259);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Summer</td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:linear-gradient(#1d976c, #93f9b9);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Spring</td></tr></table></div>";
             
            return View();
            
        }
    }
}