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
        // GET: MultiLeveLabels
        public ActionResult MultiLevelLabels()
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
            string[] xlabels = new string[11] { "Laptop", "Mobile", "Gaming", "Cosmetics", "Fragrance",
                "Watches", "Handbags", "Apparel", "Kitchenware", "Furniture", "Home Decor"};
            ViewData["xLabels"] = xlabels;
            ViewData["border"] = new { width = "0" };
            ViewData["xTextStyle"] = new { color = "black", fontFamily= "inherit"};
            string[] yLabels = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ViewData["yLabels"] = yLabels;
            ViewData["yTextStyle"] = new { color = "black", fontFamily= "inherit" };
            ViewData["dataSource"] = new HeatMapData().GetMultiLevelData();
            return View();
        }
    }
}