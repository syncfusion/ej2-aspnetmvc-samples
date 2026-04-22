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
        // GET: EmptyPoints
        public ActionResult EmptyPoints()
        {
            List<PieChartEmptyPointsData> ChartPoints = new List<PieChartEmptyPointsData>
            {
                new PieChartEmptyPointsData { Product= "Action",  ProfitPercentage= 35 },
                new PieChartEmptyPointsData { Product= "Drama",   ProfitPercentage= 25 },
                new PieChartEmptyPointsData { Product= "Comedy",  ProfitPercentage= null },
                new PieChartEmptyPointsData { Product= "Romance", ProfitPercentage= 20 },
                new PieChartEmptyPointsData { Product= "Horror",  ProfitPercentage= 10 },
                new PieChartEmptyPointsData { Product= "Sci-Fi",  ProfitPercentage= null }
            };
            ViewData["ChartPoints"] = ChartPoints;

            ViewData["data"] = new string[] { "Drop", "Average", "Zero" };
            return View();
        }

        public class PieChartEmptyPointsData
        {
            public string Product;
            public double? ProfitPercentage;
        }
    }
}