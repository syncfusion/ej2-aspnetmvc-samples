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
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: Inversed
        public ActionResult Inversed()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "inherit"
            };
            ViewData["labelTextStyle"] = new
            {
                fontFamily = "inherit"
            };
            ViewData["border"] = new { width = "0" };
            string[] xlabels = new string[10] {"China", "India", "USA", "Indonesia", "Brazil", "Pakistan",
                "Nigeria", "Bangladesh", "Russia", "Mexico"};
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[10] { "1965-1970", "1970-1975", "1975-1980", "1980-1985", "1985-1990",
                "1990-1995", "1995-2000", "2000-2005", "2005-2010", "2010-2015" };
            ViewData["yLabels"] = yLabels;
            ViewData["dataSource"] = new HeatMapData().GetInverseData();
            return View();
        }
    }
}