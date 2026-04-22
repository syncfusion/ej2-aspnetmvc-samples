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
        // GET: CombinationSeries
        public ActionResult CombinationSeries()
        {
            List<CombinationChartData> ChartPoints = new List<CombinationChartData>
            {
                new CombinationChartData { Period = "2005", PVT_Consumption = 1.2, GOVT_Consumption = 0.5, Investment = 0.7, Trade = -0.8, GDP = 1.5 },
                new CombinationChartData { Period = "2006", PVT_Consumption = 1, GOVT_Consumption = 0.5, Investment = 1.4, Trade = 0, GDP = 2.3 },
                new CombinationChartData { Period = "2007", PVT_Consumption = 1, GOVT_Consumption = 0.5, Investment = 1.5, Trade = -1, GDP = 2 },
                new CombinationChartData { Period = "2008", PVT_Consumption = 0.25, GOVT_Consumption = 0.35, Investment = 0.35, Trade = -.35, GDP = 0.1 },
                new CombinationChartData { Period = "2009", PVT_Consumption = 0.1, GOVT_Consumption = 0.9, Investment = -2.7, Trade = -0.3, GDP = -2.7 },
                new CombinationChartData { Period = "2010", PVT_Consumption = 1, GOVT_Consumption = 0.5, Investment = 0.5, Trade = -0.5, GDP = 1.8 },
                new CombinationChartData { Period = "2011", PVT_Consumption = 0.1, GOVT_Consumption = 0.25, Investment = 0.25, Trade = 0, GDP = 2 },
                new CombinationChartData { Period = "2012", PVT_Consumption = -0.25, GOVT_Consumption = -0.5, Investment = -0.1, Trade = -0.4, GDP = 0.4 },
                new CombinationChartData { Period = "2013", PVT_Consumption = 0.25, GOVT_Consumption = 0.5, Investment = -0.3, Trade = 0, GDP = 0.9 },
                new CombinationChartData { Period = "2014", PVT_Consumption = 0.6, GOVT_Consumption = 0.6, Investment = -0.6, Trade = -0.6, GDP = 0.4 },
                new CombinationChartData { Period = "2015", PVT_Consumption = 0.9, GOVT_Consumption = 0.5, Investment = 0, Trade = -0.3, GDP = 1.3 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class CombinationChartData
        {
            public string Period;
            public double PVT_Consumption;
            public double GOVT_Consumption;
            public double Investment;
            public double Trade;
            public double GDP;
        }
    }
}