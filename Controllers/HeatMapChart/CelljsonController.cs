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

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: Rowjson
        public ActionResult Celljson()
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
            ViewData["border"] = new
            {
                width = 1,
                radius = 4,
                color = "white"
            };
            string[] xlabels = new string[10] { "Austria", "China", "France", "Germany", "Italy", "Mexico", "Spain", "Thailand", "UK", "USA" };
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[7] { "2010", "2011", "2012", "2013", "2014", "2015", "2016" };
            ViewData["yLabels"] = yLabels;
            return View();
        }
    }
}