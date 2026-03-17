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

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET= Rowjson
        public ActionResult Rowjson()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewData["border"] = new
            {
                width = 1,
                radius = 4,
                color = "white"
            };
            string[] xlabels = new string[9] { "China", "France", "GBR", "Germany", "Italy", "Japan", "KOR", "Russia", "USA" };
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[5] { "2000", "2004", "2008", "2012", "2016" };
            ViewData["yLabels"] = yLabels;
            ViewData["title"] = new { text = "Olympic Year" };
            return View();
        }
    }
}
