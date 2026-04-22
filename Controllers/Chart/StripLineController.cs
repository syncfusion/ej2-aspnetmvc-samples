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
        // GET: StripLine
        public ActionResult StripLine()
        {
            List<StripLineChartData> WeatherReportsA = new List<StripLineChartData>
            {
               new StripLineChartData { X = new DateTime(2023, 5, 1), Wind = 19 },
               new StripLineChartData { X = new DateTime(2023, 5, 2), Wind = 17 },
               new StripLineChartData { X = new DateTime(2023, 5, 3), Wind = 14 },
               new StripLineChartData { X = new DateTime(2023, 5, 4), Wind = 9 },
               new StripLineChartData { X = new DateTime(2023, 5, 5), Wind = 10 },
               new StripLineChartData { X = new DateTime(2023, 5, 6), Wind = 8 },
               new StripLineChartData { X = new DateTime(2023, 5, 7), Wind = 8 },
               new StripLineChartData { X = new DateTime(2023, 5, 8), Wind = 16 },
               new StripLineChartData { X = new DateTime(2023, 5, 9), Wind = 9 },
               new StripLineChartData { X = new DateTime(2023, 5, 10), Wind = 13 },
               new StripLineChartData { X = new DateTime(2023, 5, 11), Wind = 7 },
               new StripLineChartData { X = new DateTime(2023, 5, 12), Wind = 12 },
               new StripLineChartData { X = new DateTime(2023, 5, 13), Wind = 10 },
               new StripLineChartData { X = new DateTime(2023, 5, 14), Wind = 5 },
               new StripLineChartData { X = new DateTime(2023, 5, 15), Wind = 8 }
            };
            ViewData["WeatherReportsA"] = WeatherReportsA;
            List<StripLineChartData> WeatherReportsB = new List<StripLineChartData>
            {
                new StripLineChartData { X = new DateTime(2023, 5, 1), Gust = 30 },
                new StripLineChartData { X = new DateTime(2023, 5, 2), Gust = 28 },
                new StripLineChartData { X = new DateTime(2023, 5, 3), Gust = 26 },
                new StripLineChartData { X = new DateTime(2023, 5, 4), Gust = 19 },
                new StripLineChartData { X = new DateTime(2023, 5, 5), Gust = 21 },
                new StripLineChartData { X = new DateTime(2023, 5, 6), Gust = 14 },
                new StripLineChartData { X = new DateTime(2023, 5, 7), Gust = 13 },
                new StripLineChartData { X = new DateTime(2023, 5, 8), Gust = 29 },
                new StripLineChartData { X = new DateTime(2023, 5, 9), Gust = 19 },
                new StripLineChartData { X = new DateTime(2023, 5, 10), Gust = 20 },
                new StripLineChartData { X = new DateTime(2023, 5, 11), Gust = 15 },
                new StripLineChartData { X = new DateTime(2023, 5, 12), Gust = 25 },
                new StripLineChartData { X = new DateTime(2023, 5, 13), Gust = 20 },
                new StripLineChartData { X = new DateTime(2023, 5, 14), Gust = 10 },
                new StripLineChartData { X = new DateTime(2023, 5, 15), Gust = 15 }
            };
            ViewData["WeatherReportsB"] = WeatherReportsB;
            return View();
        }
        public class StripLineChartData
        {
            public DateTime X;
            public double Wind;
            public double Gust;
        }
    }
}