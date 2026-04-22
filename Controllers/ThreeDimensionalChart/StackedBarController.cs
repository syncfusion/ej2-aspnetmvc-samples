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

namespace EJ2MVCSampleBrowser.Controllers.ThreeDimensionalChart
{
    public partial class ThreeDimensionalChartController : Controller
    {
        // GET: StackedColumn
        public ActionResult StackedBar()
        {
            List<StackedBarData> ChartPoints = new List<StackedBarData>
            {
                new StackedBarData { X = "Sochi 2014", Y = 9, Y1 = 10, Y2 = 4, Y3 = 8 },
                new StackedBarData { X = "Rio 2016", Y = 46, Y1 = 4, Y2 = 10, Y3 = 17  },
                new StackedBarData { X = "Pyeongchang 2018", Y = 9, Y1 = 11, Y2 = 5, Y3 = 14 },
                new StackedBarData { X = "Tokyo 2020", Y = 39, Y1 = 7, Y2 = 10, Y3 = 10 },
                new StackedBarData { X = "Beijing 2022", Y = 8, Y1 = 4, Y2 = 5, Y3 = 12 }
            };

            bool isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {
                ChartPoints[2].X = "Pyeongchang<br> 2018";
            };
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class StackedBarData
        {
            public string X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }
    }
}