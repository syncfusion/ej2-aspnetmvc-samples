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
        // GET: SemiPie
        public ActionResult SemiPie()
        {
            List<SemiPieChartData> chartData = new List<SemiPieChartData>
            {
                new SemiPieChartData { xValue = "Australia",         yValue = 53, text = "AUS: 14%"},
                new SemiPieChartData { xValue = "China",             yValue = 56, text = "CHN: 15%"},
                new SemiPieChartData { xValue = "India",             yValue = 61, text = "IND: 16%"},
                new SemiPieChartData { xValue = "Japan",            yValue = 13, text = "JPN: 3%"},
                new SemiPieChartData { xValue = "South Africa",      yValue = 79, text = "ZAF: 21%"},
                new SemiPieChartData { xValue = "United Kingdom",    yValue = 71, text = "UK: 19% "},
                new SemiPieChartData { xValue = "United States",     yValue = 45, text = "USA: 12 % "}
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class SemiPieChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}