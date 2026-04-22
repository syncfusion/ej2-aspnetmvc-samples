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

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: ClickPoint
        public ActionResult ClickPoint()
        {
            List<ClickPointChartData> ChartPoints = new List<ClickPointChartData>
            {
                new ClickPointChartData { X = 20,  Y = 20 },
                new ClickPointChartData { X = 80,  Y = 80 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ClickPointChartData
        {
            public double X;
            public double Y;
        }
    }
}