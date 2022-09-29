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
        // GET: StripLineRecurrence
        public ActionResult StripLineRecurrence()
        {
            List<StripLineRecurrenceChartData> chartData1 = new List<StripLineRecurrenceChartData>
            {
               new StripLineRecurrenceChartData { xValue = new DateTime(1970, 1, 1), yValue = 16500 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1975, 1, 1), yValue = 16000 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1980, 1, 1), yValue = 15400 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1985, 1, 1), yValue = 15800 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1990, 1, 1), yValue = 14000 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1995, 1, 1), yValue = 10500 },
               new StripLineRecurrenceChartData { xValue = new DateTime(2000, 1, 1), yValue = 13300 },
               new StripLineRecurrenceChartData { xValue = new DateTime(2005, 1, 1), yValue = 12800 },
            };
            List<StripLineRecurrenceChartData> chartData2 = new List<StripLineRecurrenceChartData>
            {
               new StripLineRecurrenceChartData { xValue = new DateTime(1970, 1, 1), yValue = 8000  },
               new StripLineRecurrenceChartData { xValue = new DateTime(1975, 1, 1), yValue = 7600 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1980, 1, 1), yValue = 6400 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1985, 1, 1), yValue = 3700 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1990, 1, 1), yValue = 7200 },
               new StripLineRecurrenceChartData { xValue = new DateTime(1995, 1, 1), yValue = 2300 },
               new StripLineRecurrenceChartData { xValue = new DateTime(2000, 1, 1), yValue = 4000 },
               new StripLineRecurrenceChartData { xValue = new DateTime(2005, 1, 1), yValue = 4800 },
            };
            ViewBag.dataSource1 = chartData1;
            ViewBag.dataSource2 = chartData2;
            return View();
        }
        public class StripLineRecurrenceChartData
        {
            public DateTime xValue;
            public double yValue;
        }
    }
}