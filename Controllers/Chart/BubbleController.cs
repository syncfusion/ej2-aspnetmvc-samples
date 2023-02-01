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
        // GET: Bubble
        public ActionResult Bubble()
        {
            List<BubbleChartData> chartData = new List<BubbleChartData>
            {
                new BubbleChartData { xValue = 92.2, yValue = 7.8, size = 1.347, text = "China" },
                new BubbleChartData { xValue = 74, yValue = 6.5, size = 1.241, text = "India" },
                new BubbleChartData { xValue = 90.4, yValue = 6.0, size = 0.238, text = "Indonesia"},
                new BubbleChartData { xValue = 99.4, yValue = 2.2, size = 0.312, text = "US" },
                new BubbleChartData { xValue = 88.6, yValue = 1.3, size = 0.197, text = "Brazil" },
                new BubbleChartData { xValue = 99, yValue = 0.7, size = 0.0818, text = "Germany" },
                new BubbleChartData { xValue = 72, yValue = 2.0, size = 0.0826, text = "Egypt"},
                new BubbleChartData { xValue = 99.6, yValue = 3.4, size = 0.143, text = "Russia" },
                new BubbleChartData { xValue = 99, yValue = 0.2, size = 0.128, text = "Japan" },
                new BubbleChartData { xValue = 86.1, yValue = 4.0, size = 0.115, text = "Mexico" },
                new BubbleChartData { xValue = 92.6, yValue = 6.6, size = 0.096, text = "Philippines" },
                new BubbleChartData { xValue = 61.3, yValue = 1.45, size = 0.162, text = "Nigeria" },
                new BubbleChartData { xValue = 82.2, yValue = 3.97, size = 0.7, text = "Hong Kong" },
                new BubbleChartData { xValue = 79.2, yValue = 3.9, size = 0.162, text = "Netherland" },
                new BubbleChartData { xValue = 72.5, yValue = 4.5, size = 0.7, text = "Jordan" },
                new BubbleChartData { xValue = 81, yValue = 3.5, size = 0.21, text = "Australia" },
                new BubbleChartData { xValue = 66.8, yValue = 3.9, size = 0.028, text = "Mongolia" },
                new BubbleChartData { xValue = 78.4, yValue = 2.9, size = 0.231, text = "Taiwan" },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class BubbleChartData
        {
            public double xValue;
            public double yValue;
            public double size;
            public string text;
        }

    }
}