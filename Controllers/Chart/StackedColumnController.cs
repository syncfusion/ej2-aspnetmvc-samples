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
        // GET: StackedColumn
        public ActionResult StackedColumn()
        {
            List<StackedColumnChartData> ChartPoints = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { X = "2019", Y = 28.5 },
                new StackedColumnChartData { X = "2020", Y = 27.5 },
                new StackedColumnChartData { X = "2021", Y = 24.3 },
                new StackedColumnChartData { X = "2022", Y = 26.3 },
                new StackedColumnChartData { X = "2023", Y = 25.4 },
                new StackedColumnChartData { X = "2024", Y = 25 }
            };
            List<StackedColumnChartData> ChartPoints1 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { X = "2019", Y = 26.9 },
                new StackedColumnChartData { X = "2020", Y = 29.3 },
                new StackedColumnChartData { X = "2021", Y = 26.7 },
                new StackedColumnChartData { X = "2022", Y = 30.8 },
                new StackedColumnChartData { X = "2023", Y = 27.4 },
                new StackedColumnChartData { X = "2024", Y = 31 }
            };
            List<StackedColumnChartData> ChartPoints2 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { X = "2019", Y = 19.9 },
                new StackedColumnChartData { X = "2020", Y = 14.6 },
                new StackedColumnChartData { X = "2021", Y = 17.5 },
                new StackedColumnChartData { X = "2022", Y = 14.5 },
                new StackedColumnChartData { X = "2023", Y = 12.1 },
                new StackedColumnChartData { X = "2024", Y = 14.4 }
            };
            bool isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {
                ChartPoints.RemoveRange(0, 2);
                ChartPoints1.RemoveRange(0, 2);
                ChartPoints2.RemoveRange(0, 2);

            };

            ViewData["ChartPoints"] = ChartPoints;
            ViewData["ChartPoints1"] = ChartPoints1;
            ViewData["ChartPoints2"] = ChartPoints2;
            return View();
        }
        public class StackedColumnChartData
        {
            public string X;
            public double Y;
        }
    }
}