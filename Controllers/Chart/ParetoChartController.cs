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
        // GET: ParetoChart
        public ActionResult ParetoChart()
        {
            List<ParetoChartData> ChartPoints = new List<ParetoChartData>
            {
                new ParetoChartData { DefectCategory = "Button Defect", Y = 23 },
                new ParetoChartData { DefectCategory = "Pocket Defect", Y = 16 },
                new ParetoChartData { DefectCategory = "Collar Defect", Y = 10 },
                new ParetoChartData { DefectCategory = "Cuff Defect", Y = 7 },
                new ParetoChartData { DefectCategory = "Sleeve Defect", Y = 6 },
                new ParetoChartData { DefectCategory = "Other Defect", Y = 2 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ParetoChartData
        {
            public string DefectCategory;
            public double Y;
        }
    }
}