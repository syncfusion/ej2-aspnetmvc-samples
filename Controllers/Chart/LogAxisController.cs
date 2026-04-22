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
        // GET: LogAxis
        public ActionResult LogAxis()
        {
            List<LogAxisChartData> ChartPoints = new List<LogAxisChartData>
            {
                new LogAxisChartData { Period = new DateTime(1995, 1, 1),  ProfitInfo = 80  },
                new LogAxisChartData { Period = new DateTime(1996, 1, 1),  ProfitInfo = 200 },
                new LogAxisChartData { Period = new DateTime(1997, 1, 1),  ProfitInfo = 400 },
                new LogAxisChartData { Period = new DateTime(1998, 1, 1),  ProfitInfo = 600 },
                new LogAxisChartData { Period = new DateTime(1999, 1, 1),  ProfitInfo = 700 },
                new LogAxisChartData { Period = new DateTime(2000, 1, 1),  ProfitInfo = 1400 },
                new LogAxisChartData { Period = new DateTime(2001, 1, 1),  ProfitInfo = 2000 },
                new LogAxisChartData { Period = new DateTime(2002, 1, 1),  ProfitInfo = 4000 },
                new LogAxisChartData { Period = new DateTime(2003, 1, 1),  ProfitInfo = 6000 },
                new LogAxisChartData { Period = new DateTime(2004, 1, 1),  ProfitInfo = 8000 },
                new LogAxisChartData { Period = new DateTime(2005, 1, 1),  ProfitInfo = 11000 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class LogAxisChartData
        {
            public DateTime Period;
            public double ProfitInfo;
        }
    }
}