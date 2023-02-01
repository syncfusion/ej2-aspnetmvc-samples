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
        // GET: Line
        public ActionResult Line()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
                new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
                new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
                new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
                new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
                new LineChartData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
                new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
                new LineChartData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class LineChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }
    }
}