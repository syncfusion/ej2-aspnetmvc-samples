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
        // GET: Bar
        public ActionResult Bar()
        {
            List<BarData> ChartPoints = new List<BarData>
            {
                new BarData { X = "Japan", Y = 1.71, Y1 = 6.02  },
                new BarData { X = "France", Y = 1.82, Y1 = 3.19  },
                new BarData { X = "India", Y = 6.68, Y1 = 3.28  },
                new BarData { X = "Germany", Y = 2.22, Y1 = 4.56 },
                new BarData { X = "Italy", Y = 1.50, Y1 = 2.40  },
                new BarData { X = "Canada", Y = 3.05, Y1 = 2.04 }
            };
            
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class BarData
        {
            public string X;
            public double Y;
            public double Y1;
        }
    }
}