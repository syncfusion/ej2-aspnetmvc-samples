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

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: MultiDataMapping
        public ActionResult ColorAndSizeAttributes()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] xlabels = new string[6] { "2017", "2016", "2015", "2014", "2013", "2012" };
            ViewData["xLabels"] = xlabels;
            ViewData["border"] = new
            {
                width = "0"
            };
            string[] yLabels = new string[6] { "Jan-Feb", "Mar-Apr", "May-Jun", "Jul-Aug", "Sep-Oct", "Nov-Dec" };
            ViewData["yLabels"] = yLabels;
            ViewData["dataSource"] = new HeatMapData().tableBubbleData();
            return View();
        }
    }
}