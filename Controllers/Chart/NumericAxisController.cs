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
        // GET: NumericAxis
        public ActionResult NumericAxis()
        {
            List<DoubleAxisData> ChartPoints = new List<DoubleAxisData>
            {
                new DoubleAxisData { Over = 16, ENG_Score = 2, WI_Score = 7},
                new DoubleAxisData { Over = 17, ENG_Score = 14, WI_Score = 7 },
                new DoubleAxisData { Over = 18, ENG_Score = 7, WI_Score = 11 },
                new DoubleAxisData { Over = 19, ENG_Score = 7, WI_Score = 8 },
                new DoubleAxisData { Over = 20, ENG_Score = 10, WI_Score = 24 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["font"] = new { fontWeight = "600", color = "#ffffff" };
            return View();
        }
        public class DoubleAxisData
        {
            public double Over;
            public double ENG_Score;
            public double WI_Score;
        }
    }
}