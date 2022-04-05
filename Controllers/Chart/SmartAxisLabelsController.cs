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
        // GET: SmartAxisLabels
        public ActionResult SmartAxisLabels()
        {
            List<SmartAxisLabelsChartData> chartData = new List<SmartAxisLabelsChartData>
            {
                new SmartAxisLabelsChartData { xValue = "South Korea",  yValue = 39 },
                new SmartAxisLabelsChartData { xValue = "India",        yValue = 61 },
                new SmartAxisLabelsChartData { xValue = "Pakistan",     yValue = 20 },
                new SmartAxisLabelsChartData { xValue = "Germany",      yValue = 65 },
                new SmartAxisLabelsChartData { xValue = "Australia",    yValue = 16 },
                new SmartAxisLabelsChartData { xValue = "Italy",        yValue = 29 },
                new SmartAxisLabelsChartData { xValue = "France",       yValue = 45 },
                new SmartAxisLabelsChartData { xValue = "Saudi Arabia", yValue = 10 },
                new SmartAxisLabelsChartData { xValue = "Russia",       yValue = 41 },
                new SmartAxisLabelsChartData { xValue = "Mexico",       yValue = 31 },
                new SmartAxisLabelsChartData { xValue = "Brazil",       yValue = 76 },
                new SmartAxisLabelsChartData { xValue = "China",        yValue = 51 }

            };
            ViewBag.dataSource = chartData;
            ViewBag.font = new { fontWeight = "600", color = "#ffffff" };
            ViewBag.data = new string[] { "Hide", "Trim", "Wrap", "MultipleRows", "Rotate45", "Rotate90", "None" };
            ViewBag.data1 = new string[] { "None", "Hide", "Shift" };
            ViewBag.data2 = new string[] { "Outside", "Inside" };
            return View();
        }
        public class SmartAxisLabelsChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}