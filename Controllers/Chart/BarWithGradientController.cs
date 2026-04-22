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
        // GET: BarWithGradient
        public ActionResult BarWithGradient()
        {
            var chartPoints = new List<BarGradientData>
            {
                new BarGradientData { Company = "Tata Motors", Revenue = 52.9 },
                new BarGradientData { Company = "State Bank of India", Revenue = 71.8 },
                new BarGradientData { Company = "Oil and Natural Gas Corporation", Revenue = 77.5 },
                new BarGradientData { Company = "Indian Oil Corporation", Revenue = 93.8 },
                new BarGradientData { Company = "Life Insurance Corporation of India", Revenue = 98.0 },
                new BarGradientData { Company = "Reliance Industries", Revenue = 108.8 }
            };

            ViewBag.ChartPoints = chartPoints;
            return View();
        }
    }
    public class BarGradientData
    {
        public string Company { get; set; }
        public double Revenue { get; set; }
    }
}
