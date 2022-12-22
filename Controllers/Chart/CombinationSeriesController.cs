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
        // GET: CombinationSeries
        public ActionResult CombinationSeries()
        {
            List<CombinationChartData> chartData = new List<CombinationChartData>
            {
                new CombinationChartData { xValue = "2007", yValue = 1    , yValue1 = 0.5 , yValue2 = 1.5 , yValue3 = -1  , yValue4 = 2   },
                new CombinationChartData { xValue = "2008", yValue = 0.25 , yValue1 = 0.35, yValue2 = 0.35, yValue3 = -.35, yValue4 = 0.1 },
                new CombinationChartData { xValue = "2009", yValue = 0.1  , yValue1 = 0.9 , yValue2 = -2.7, yValue3 = -0.3, yValue4 = -2.7},
                new CombinationChartData { xValue = "2010", yValue = 1    , yValue1 = 0.5 , yValue2 = 0.5 , yValue3 = -0.5, yValue4 = 1.8 },
                new CombinationChartData { xValue = "2011", yValue = 0.1  , yValue1 = 0.25, yValue2 = 0.25, yValue3 = 0   , yValue4 = 2   },
                new CombinationChartData { xValue = "2012", yValue = -0.25, yValue1 = -0.5, yValue2 = -0.1, yValue3 = -0.4, yValue4 = 0.4 },
                new CombinationChartData { xValue = "2013", yValue = 0.25 , yValue1 = 0.5 , yValue2 = -0.3, yValue3 = 0   , yValue4 = 0.9 },
                new CombinationChartData { xValue = "2014", yValue = 0.6  , yValue1 = 0.6 , yValue2 = -0.6, yValue3 = -0.6, yValue4 = 0.4 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class CombinationChartData
        {
            public string xValue;
            public double yValue;
            public double yValue1;
            public double yValue2;
            public double yValue3;
            public double yValue4;
        }
    }
}