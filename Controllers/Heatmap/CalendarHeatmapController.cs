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
        // GET: CalendarHeatmap
        public ActionResult CalendarHeatmap()
        {
            ViewData["textStyle"] = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] yLabels = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ViewData["yLabels"] = yLabels;
            ViewData["border"] = new { color = "white" };
            ViewData["dataSource"] = new HeatMapData().GetCalendarData();
            return View();
        }
    }
}