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
        // GET: ErrorBar
        public ActionResult ErrorBar()
        {
            List<ErrorBarChartData> ChartPoints = new List<ErrorBarChartData>
            {
                new ErrorBarChartData { Items = "Printer", Quality = 750, error=50 },
                new ErrorBarChartData { Items = "Desktop", Quality = 500, error=70 },
                new ErrorBarChartData { Items = "Charger", Quality = 550, error=60 },
                new ErrorBarChartData { Items = "Mobile", Quality = 575, error=80 },
                new ErrorBarChartData { Items = "Keyboard", Quality = 400, error=20 },
                new ErrorBarChartData { Items = "Power Bank", Quality = 450, error=90 },
                new ErrorBarChartData { Items = "Laptop", Quality = 650, error=40 },
                new ErrorBarChartData { Items = "Battery", Quality = 525, error=84 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class ErrorBarChartData
        {
            public string Items;
            public double Quality;
            public double error;
        }
    }
}