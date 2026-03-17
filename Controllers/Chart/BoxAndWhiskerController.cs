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
            Double[] y3 = { 26, 27, 28, 30, 32, 34, 35, 37, 35, 37, 45 };
            Double[] y4 = { 26, 27, 29, 32, 34, 35, 36, 37, 38, 39, 41, 43, 58 };
            Double[] y5 = { 27, 26, 28, 29, 29, 29, 32, 35, 32, 38, 53 };
            Double[] y6 = { 21, 23, 24, 25, 26, 27, 28, 30, 34, 36, 38 };
            Double[] y7 = { 26, 28, 29, 30, 32, 33, 35, 36, 52 };
            Double[] y8 = { 28, 29, 30, 31, 32, 34, 35, 36 };
            Double[] y9 = { 22, 24, 25, 30, 32, 34, 36, 38, 39, 41, 35, 36, 40, 56 };

            List<BoxAndWhiskerChartData> ChartPoints = new List<BoxAndWhiskerChartData>
            {
                new BoxAndWhiskerChartData { Department = "Development", Age = y1 },
                new BoxAndWhiskerChartData { Department = "Testing", Age = y2},
                new BoxAndWhiskerChartData { Department = "Finance", Age = y3 },
                new BoxAndWhiskerChartData { Department = "R&D", Age = y4 },
                new BoxAndWhiskerChartData { Department = "Sales", Age = y5 },
                new BoxAndWhiskerChartData { Department = "Inventory", Age = y6 },
                new BoxAndWhiskerChartData { Department = "Graphics", Age = y7 },
                new BoxAndWhiskerChartData { Department = "Training", Age = y8 },
                new BoxAndWhiskerChartData { Department = "HR", Age = y9 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class BoxAndWhiskerChartData
        {
            public string Department;
            public double[] Age;
        }
    }
}