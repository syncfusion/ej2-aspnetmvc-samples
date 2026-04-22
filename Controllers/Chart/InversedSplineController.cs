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
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: InversedSpline
        public ActionResult InversedSpline()
        {
            List<InversedLineChartData> ChartPoints = new List<InversedLineChartData>
            {
                new InversedLineChartData { Country = "United States", Y = 194.55 },
                new InversedLineChartData { Country = "Japan", Y = 146.2 },
                new InversedLineChartData { Country = "China", Y = 65.1 },
                new InversedLineChartData { Country = "France", Y = 84.9 },
                new InversedLineChartData { Country = "India", Y = 140.1 },
                new InversedLineChartData { Country = "Canada", Y = 160.7 },
                new InversedLineChartData { Country = "Brazil", Y = 68.4 },
                new InversedLineChartData { Country = "United Kingdom", Y = 100.2 },
                new InversedLineChartData { Country = "Sweden", Y = 162 },
                new InversedLineChartData { Country = "Netherlands", Y = 132.3 },
                new InversedLineChartData { Country = "Bangladesh", Y = 27.7 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }

        public class InversedLineChartData
        {
            public string Country;
            public double Y ;
        }
    }
}