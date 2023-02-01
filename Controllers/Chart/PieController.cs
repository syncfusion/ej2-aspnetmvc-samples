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
        // GET: Pie
        public ActionResult Pie()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Chrome", yValue = 37, text = "37%"},
                new PieChartData { xValue = "UC Browser", yValue = 17, text = "17%"},
                new PieChartData { xValue = "iPhone", yValue = 19, text = "19%"},
                new PieChartData { xValue = "Others", yValue = 4 , text = "4%"},
                new PieChartData { xValue = "Opera", yValue = 11, text = "11%"},
                new PieChartData { xValue = "Android", yValue = 12, text = "12%"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }

    }
}