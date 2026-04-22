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

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: LiveChartDataSorting
        public ActionResult LiveChartDataSorting()
        {
            List<LiveChartData> ChartPoints = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 97.21 },
                new LiveChartData { X = "France",         Y = 95.21 },
                new LiveChartData { X = "Indonesia",      Y = 62.74 },
                new LiveChartData { X = "Iceland",        Y = 61.71 },
                new LiveChartData { X = "United States",  Y = 57.97 },
                new LiveChartData { X = "Greece",         Y = 57.51 },
                new LiveChartData { X = "Iran",           Y = 55.31 },
                new LiveChartData { X = "Canada",         Y = 48.76 },
                new LiveChartData { X = "Finland",        Y = 48.50 },
                new LiveChartData { X = "Brazil",         Y = 45.13 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            List<LiveChartData> ChartPoints2 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 102.54 },
                new LiveChartData { X = "France",         Y = 90.76 },
                new LiveChartData { X = "Indonesia",      Y = 64.61 },
                new LiveChartData { X = "Iceland",        Y = 70.95 },
                new LiveChartData { X = "United States",  Y = 61.52 },
                new LiveChartData { X = "Greece",         Y = 49.03 },
                new LiveChartData { X = "Iran",           Y = 33.05 },
                new LiveChartData { X = "Canada",         Y = 59.83 },
                new LiveChartData { X = "Finland",        Y = 43.13 },
                new LiveChartData { X = "Brazil",         Y = 55.56 }
            };
            ViewData["ChartPoints2"] = ChartPoints2;
            List<LiveChartData> ChartPoints3 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 99.33 },
                new LiveChartData { X = "France",         Y = 94.50 },
                new LiveChartData { X = "Indonesia",      Y = 64.86 },
                new LiveChartData { X = "Iceland",        Y = 77.86 },
                new LiveChartData { X = "United States",  Y = 62.14 },
                new LiveChartData { X = "Greece",         Y = 47.73 },
                new LiveChartData { X = "Iran",           Y = 39.97 },
                new LiveChartData { X = "Canada",         Y = 66.53 },
                new LiveChartData { X = "Finland",        Y = 43.15 },
                new LiveChartData { X = "Brazil",         Y = 50.02 }
            };
            ViewData["ChartPoints3"] = ChartPoints3;
            List<LiveChartData> ChartPoints4 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 98.85 },
                new LiveChartData { X = "France",         Y = 101.11 },
                new LiveChartData { X = "Indonesia",      Y = 60.72 },
                new LiveChartData { X = "Iceland",        Y = 71.09 },
                new LiveChartData { X = "United States",  Y = 60.97 },
                new LiveChartData { X = "Greece",         Y = 52.07 },
                new LiveChartData { X = "Iran",           Y = 37.99 },
                new LiveChartData { X = "Canada",         Y = 58.35 },
                new LiveChartData { X = "Finland",        Y = 43.41 },
                new LiveChartData { X = "Brazil",         Y = 58.61 }
            };
            ViewData["ChartPoints4"] = ChartPoints4;
            List<LiveChartData> ChartPoints5 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 100.02 },
                new LiveChartData { X = "France",         Y = 100.55 },
                new LiveChartData { X = "Indonesia",      Y = 62.84 },
                new LiveChartData { X = "Iceland",        Y = 89.05 },
                new LiveChartData { X = "United States",  Y = 59.46 },
                new LiveChartData { X = "Greece",         Y = 54.04 },
                new LiveChartData { X = "Iran",           Y = 42.58 },
                new LiveChartData { X = "Canada",         Y = 59.90 },
                new LiveChartData { X = "Finland",        Y = 46.18 },
                new LiveChartData { X = "Brazil",         Y = 65.06 }
            };
            ViewData["ChartPoints5"] = ChartPoints5;
            List<LiveChartData> ChartPoints6 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 102.54 },
                new LiveChartData { X = "France",         Y = 103.56 },
                new LiveChartData { X = "Indonesia",      Y = 60.23 },
                new LiveChartData { X = "Iceland",        Y = 94.00 },
                new LiveChartData { X = "United States",  Y = 59.39 },
                new LiveChartData { X = "Greece",         Y = 50.11 },
                new LiveChartData { X = "Iran",           Y = 34.23 },
                new LiveChartData { X = "Canada",         Y = 60.40 },
                new LiveChartData { X = "Finland",        Y = 44.73 },
                new LiveChartData { X = "Brazil",         Y = 50.04 }
            };
            ViewData["ChartPoints6"] = ChartPoints6;
            List<LiveChartData> ChartPoints7 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 98.84 },
                new LiveChartData { X = "France",         Y = 101.95 },
                new LiveChartData { X = "Indonesia",      Y = 60.86 },
                new LiveChartData { X = "Iceland",        Y = 89.51 },
                new LiveChartData { X = "United States",  Y = 58.26 },
                new LiveChartData { X = "Greece",         Y = 53.20 },
                new LiveChartData { X = "Iran",           Y = 34.28 },
                new LiveChartData { X = "Canada",         Y = 57.22 },
                new LiveChartData { X = "Finland",        Y = 42.99 },
                new LiveChartData { X = "Brazil",         Y = 51.68 }
            };
            ViewData["ChartPoints7"] = ChartPoints7;
            List<LiveChartData> ChartPoints8 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 100.41 },
                new LiveChartData { X = "France",         Y = 108.54 },
                new LiveChartData { X = "Indonesia",      Y = 56.44 },
                new LiveChartData { X = "Iceland",        Y = 107.98 },
                new LiveChartData { X = "United States",  Y = 57.75 },
                new LiveChartData { X = "Greece",         Y = 56.34 },
                new LiveChartData { X = "Iran",           Y = 35.53 },
                new LiveChartData { X = "Canada",         Y = 57.49 },
                new LiveChartData { X = "Finland",        Y = 43.32 },
                new LiveChartData { X = "Brazil",         Y = 64.56 }
            };
            ViewData["ChartPoints8"] = ChartPoints8;
            List<LiveChartData> ChartPoints9 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 104.45 },
                new LiveChartData { X = "France",         Y = 102.07 },
                new LiveChartData { X = "Indonesia",      Y = 61.19 },
                new LiveChartData { X = "Iceland",        Y = 97.05 },
                new LiveChartData { X = "United States",  Y = 59.53 },
                new LiveChartData { X = "Greece",         Y = 55.61 },
                new LiveChartData { X = "Iran",           Y = 41.84 },
                new LiveChartData { X = "Canada",         Y = 64.13 },
                new LiveChartData { X = "Finland",        Y = 43.69 },
                new LiveChartData { X = "Brazil",         Y = 64.73 }
            };
            ViewData["ChartPoints9"] = ChartPoints9;
            List<LiveChartData> ChartPoints10 = new List<LiveChartData>
            {
                new LiveChartData { X = "India",          Y = 111.84 },
                new LiveChartData { X = "France",         Y = 95.53 },
                new LiveChartData { X = "Indonesia",      Y = 55.15 },
                new LiveChartData { X = "Iceland",        Y = 85.79 },
                new LiveChartData { X = "United States",  Y = 59.53 },
                new LiveChartData { X = "Greece",         Y = 58.93 },
                new LiveChartData { X = "Iran",           Y = 46.53 },
                new LiveChartData { X = "Canada",         Y = 59.52 },
                new LiveChartData { X = "Finland",        Y = 45.67 },
                new LiveChartData { X = "Brazil",         Y = 67.84 }
            };
            ViewData["ChartPoints10"] = ChartPoints10;
            return View();
        }
        public class LiveChartData
        {
            public string X;
            public double Y;
        }
    }
}