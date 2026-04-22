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
using Syncfusion.DocIO.DLS;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Waterfall
        public ActionResult Waterfall()
        {
            List<WaterfallChartData> ChartPoints = new List<WaterfallChartData>
            {
                new WaterfallChartData { X = "Income", Y = 971  },
                new WaterfallChartData { X = "Sales", Y = -101 },
                new WaterfallChartData { X = "Development", Y = -268 },
                new WaterfallChartData { X = "Revenue", Y = 403 },
                new WaterfallChartData { X = "Balance" },
                new WaterfallChartData { X = "Expense", Y = -136 },
                new WaterfallChartData { X = "Tax", Y = -365 },
                new WaterfallChartData { X = "Net Profit" },
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["intermediateSumIndexes"] = new int[] {4};
            ViewData["sumIndexes"] = new int[] {7};
            ViewData["connector"] = new {width = 0.8, dashArray = "1,2", color = "#5F6A6A"};
            return View();
        }
        public class WaterfallChartData
        {
            public string X;
            public double Y;
        }
    }
}