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
        // GET: NumericAxis
        public ActionResult NumericAxis()
        {
            List<DoubleAxisData> chartData = new List<DoubleAxisData>
            {
                new DoubleAxisData { xValue = 16, yValue1 = 2, yValue2= 7},
                new DoubleAxisData { xValue = 17, yValue1 = 14, yValue2 = 7 },
                new DoubleAxisData { xValue = 18, yValue1 = 7, yValue2 = 11 },
                new DoubleAxisData { xValue = 19, yValue1 = 7, yValue2 = 8 },
                new DoubleAxisData { xValue = 20, yValue1 = 10, yValue2 = 24 },
                            };
            ViewBag.dataSource = chartData;
            ViewBag.font = new { fontWeight = "600", color = "#ffffff" };
            return View();
        }
        public class DoubleAxisData
        {
            public double xValue;
            public double yValue1;
            public double yValue2;
        }
    }
}