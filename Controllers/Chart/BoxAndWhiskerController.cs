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
        // GET: BoxAndWhisker
        public ActionResult BoxAndWhisker()
        {
            Double[] y1 = { 22, 22, 23, 25, 25, 25, 26, 27, 27, 28, 28, 29, 30, 32, 34, 32, 34, 36, 35, 38 };
            Double[] y2 = { 22, 33, 23, 25, 26, 28, 29, 30, 34, 33, 32, 31, 50 };
            Double[] y3 = { 22, 24, 25, 30, 32, 34, 36, 38, 39, 41, 35, 36, 40, 56 };
            Double[] y4 = { 26, 27, 28, 30, 32, 34, 35, 37, 35, 37, 45 };
            Double[] y5 = { 26, 27, 29, 32, 34, 35, 36, 37, 38, 39, 41, 43, 58 };
            Double[] y6 = { 27, 26, 28, 29, 29, 29, 32, 35, 32, 38, 53 };
            Double[] y7 = { 21, 23, 24, 25, 26, 27, 28, 30, 34, 36, 38 };
            Double[] y8 = { 26, 28, 29, 30, 32, 33, 35, 36, 52 };
            Double[] y9 = { 28, 29, 30, 31, 32, 34, 35, 36 };

            List<BoxAndWhiskerChartData> chartData = new List<BoxAndWhiskerChartData>
            {
                new BoxAndWhiskerChartData { xValue = "Development", yValue = y1 },
                new BoxAndWhiskerChartData { xValue = "Testing", yValue = y2},
                new BoxAndWhiskerChartData { xValue = "HR", yValue = y3 },
                new BoxAndWhiskerChartData { xValue = "Finance", yValue = y4 },
                new BoxAndWhiskerChartData { xValue = "R&D", yValue = y5 },
                new BoxAndWhiskerChartData { xValue = "Sales", yValue = y6 },
                new BoxAndWhiskerChartData { xValue = "Inventory", yValue = y7 },
                new BoxAndWhiskerChartData { xValue = "Graphics", yValue = y8 },
                new BoxAndWhiskerChartData { xValue = "Training", yValue = y9 },
            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "Normal","Exclusive","Inclusive" };
            return View();
        }
        public class BoxAndWhiskerChartData
        {
            public string xValue;
            public double[] yValue;
        }
    }
}