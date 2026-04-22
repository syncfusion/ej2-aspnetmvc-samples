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
        // GET: Emptypoints
        public ActionResult Emptypoints()
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
                fontFamily= "inherit"
            };
            ViewData["border"] = new { width = "0", color= "white" };
            ViewData["cellTextStyle"] = new { color = "white" };
            string[] xlabels = new string[11] { "2007", "2008", "2009", "2010", "2011",
                "2012", "2013", "2014", "2015", "2016", "2017"};
            ViewData["xLabels"] = xlabels;
            string[] yLabels = new string[12] { "Jan", "Feb", "Mar", "Apr", "May",
                "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
            ViewData["yLabels"] = yLabels;
            int?[,] dataSource = new int?[,]
            {
                {8, 5, 2, 6, 8, 2, 9, 3, 7, 8, 7, 6},
                {5, null, 4, 9, 10, null, 11, 7, 3, 7, 8, null},
                {8, 7, 2, null, 5, 3, null, 2, 1, 8, null, 4},
                {10, 2, null, 4, 5, null, 1, 10, 5, 2, 1, null},
                {1, 2, 9, 4, null, 5, 1, null, 12, 1, null, 4},
                {4, null, 3, 5, 2, null, null, null, 5, null, 1, 3},
                {null, null, 4, 10, null, 5, 11, 2, 8, 1, null, 1},
                {1, 4, null, 4, 5, null, 1, 3, null, 1, null, 3},
                {null, 2, 1, 4, null, 5, 1, null, 2, 1, null, 2},
                {1, null, 4, null, null, 2, null, 5, 1, 5, 2, 1},
                {1, null, 2, 1, 5, null, null, null, 5, 2, 1, null}
            };
            ViewData["dataSource"] = dataSource;

            return View();
        }
    }
}