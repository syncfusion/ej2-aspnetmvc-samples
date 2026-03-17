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
        // GET: InversedAxis
        public ActionResult InversedAxis()
        {
            
            List<InversedAxisChartData> ChartPoints = new List<InversedAxisChartData>
            {
                new InversedAxisChartData { Year = "2008", ExchangeRate = 1.5 },
                new InversedAxisChartData { Year = "2009", ExchangeRate = 7.6 },
                new InversedAxisChartData { Year = "2010", ExchangeRate = 11 },
                new InversedAxisChartData { Year = "2011", ExchangeRate = 16.2 },
                new InversedAxisChartData { Year = "2012", ExchangeRate = 18 },
                new InversedAxisChartData { Year = "2013", ExchangeRate = 21.4 },
                new InversedAxisChartData { Year = "2014", ExchangeRate = 16 },
                new InversedAxisChartData { Year = "2015", ExchangeRate = 17.1 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class InversedAxisChartData
        {
            public string Year;
            public double ExchangeRate;
        }
    }
}