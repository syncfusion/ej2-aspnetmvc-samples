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
        // GET: PieWithLegend
        public ActionResult PieWithLegend()
        {
            List<PieWithLegendChartData> PieChartPoints = new List<PieWithLegendChartData>
            {
                new PieWithLegendChartData { X = "China",     Y = 35,   Text = "35%" },
                new PieWithLegendChartData { X = "India",     Y = 30,   Text = "30%" },
                new PieWithLegendChartData { X = "USA",       Y = 10.7, Text = "10.7%" },
                new PieWithLegendChartData { X = "Indonesia", Y = 7,    Text = "7%" },
                new PieWithLegendChartData { X = "Brazil",    Y = 5.3,  Text = "5.3%" },
                new PieWithLegendChartData { X = "Others",    Y = 12,   Text = "12%" }
            };
            ViewData["PieChartPoints"] = PieChartPoints;
            return View();
        }
        public class PieWithLegendChartData
        {
            public string X;
            public double Y;
            public string Text;
        }
    }
}