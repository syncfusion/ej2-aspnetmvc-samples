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

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: HorizontalWaterFallChart
        public ActionResult HorizontalWaterFallChart()
        {
            List<HorizontalChartData> ChartPoints = new List<HorizontalChartData>
            {
                new HorizontalChartData { X = "JAN",   Y = 55 },
                new HorizontalChartData { X = "MAR",   Y = 42 },
                new HorizontalChartData { X = "JUNE",  Y = -12 },
                new HorizontalChartData { X = "AUG",   Y = 40 },
                new HorizontalChartData { X = "OCT",   Y = -26 },
                new HorizontalChartData { X = "DEC",   Y = 45 },
                new HorizontalChartData { X = "2023" }
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["sumIndexes"] = new int[] { 6 };
            ViewData["connector"] = new { width = 0.8, dashArray = "1,2", color = "#5F6A6A" };
            return View();
        }
        public class HorizontalChartData
        {
            public string X;
            public double Y;
        }
    }
}