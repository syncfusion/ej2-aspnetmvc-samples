#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        // GET: PieWithLegend
        public ActionResult PieWithLegend()
        {
            List<PieWithLegendChartData> chartData = new List<PieWithLegendChartData>
            {
                new PieWithLegendChartData { x =  "Internet Explorer", y = 6.12, text="Internet <br> Explorer" },
                new PieWithLegendChartData { x =  "Chrome", y = 57.28, text="Chrome" },
                new PieWithLegendChartData { x =  "Safari", y = 4.73, text="Safari" },
                new PieWithLegendChartData { x =  "QQ", y = 5.96, text="QQ" },
                new PieWithLegendChartData { x =  "UC Browser", y = 4.37, text="UC Browser" },
                new PieWithLegendChartData { x =  "Edge", y = 7.48, text="Edge" },
                new PieWithLegendChartData { x =  "Others", y = 14.06, text="Others" }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieWithLegendChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}