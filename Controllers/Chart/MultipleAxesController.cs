#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        // GET: MultipleAxes
        public ActionResult MultipleAxes()
        {
            ViewBag.content1 = "#chart_cloud";
            ViewBag.content = "#chart_sunny";

            List<MultipleAxesChartData> chartData = new List<MultipleAxesChartData>
            {
                new MultipleAxesChartData { x = "Sun", y = 35, y1 = 30 },
                new MultipleAxesChartData { x = "Mon", y = 40, y1 = 28 },
                new MultipleAxesChartData { x = "Tue", y = 80, y1 = 29 },
                new MultipleAxesChartData { x = "Wed", y = 70, y1 = 30 },
                new MultipleAxesChartData { x = "Thu", y = 65, y1 = 33 },
                new MultipleAxesChartData { x = "Fri", y = 55, y1 = 32 },
                new MultipleAxesChartData { x = "Sat", y = 50, y1 = 34 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class MultipleAxesChartData
        {
            public string x;
            public double y;
            public double y1;
        }
    }
}