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
        // GET: Grouping
        public ActionResult Grouping()
        {
            List<GroupingChartData> chartData = new List<GroupingChartData>
            {

                new GroupingChartData { xValue = "China",         yValue = 26, text = "China: 26" },
                new GroupingChartData { xValue = "Russia",        yValue = 19, text = "Russia: 19" },
                new GroupingChartData { xValue = "Germany",       yValue = 17, text = "Germany: 17" },
                new GroupingChartData { xValue = "Japan",         yValue = 12, text = "Japan: 12" },
                new GroupingChartData { xValue = "France",        yValue = 10, text = "France: 10" },
                new GroupingChartData { xValue = "South Korea",   yValue = 9,  text = "South Korea: 9" },
                new GroupingChartData { xValue = "Great Britain", yValue = 27, text = "Great Britain: 27" },
                new GroupingChartData { xValue = "Italy",         yValue = 8,  text = "Italy: 8" },
                new GroupingChartData { xValue = "Australia",     yValue = 8,  text = "Australia: 8" },
                new GroupingChartData { xValue = "Netherlands",   yValue = 8,  text = "Netherlands: 8" },
                new GroupingChartData { xValue = "Hungary",       yValue = 8,  text = "Hungary: 8" },
                new GroupingChartData { xValue = "Brazil",        yValue = 7,  text = "Brazil: 7" },
                new GroupingChartData { xValue = "Spain",         yValue = 7,  text = "Spain: 7" },
                new GroupingChartData { xValue = "Kenya",         yValue = 6,  text = "Kenya: 6" }

            };
            ViewBag.animation = new ChartAnimation { Enable = true };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "Point", "Value" };
            return View();
        }
        public class GroupingChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}