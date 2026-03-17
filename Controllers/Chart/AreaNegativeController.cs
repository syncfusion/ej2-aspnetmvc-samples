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
        // GET: AreaEmptyPoints
        public ActionResult AreaNegative()
        {
            List<AreaNegativeChartData> MaryValues = new List<AreaNegativeChartData>
            {
                new AreaNegativeChartData { Vegetable = new DateTime(2017, 01, 01),  Price = 3000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2018, 01, 01), Price = 4000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2019, 01, 01), Price = -4000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2020, 01, 01),   Price = -2000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2021, 01, 01), Price = 5000 }
            };
            List<AreaNegativeChartData> PatriciaValues = new List<AreaNegativeChartData>
            {
                new AreaNegativeChartData { Vegetable = new DateTime(2017, 01, 01),  Price = 2000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2018, 01, 01), Price = 3000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2019, 01, 01), Price = 4000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2020, 01, 01),   Price = 2000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2021, 01, 01), Price = 3000 }
            };
            List<AreaNegativeChartData> LindaValues = new List<AreaNegativeChartData>
            {
                new AreaNegativeChartData { Vegetable = new DateTime(2017, 01, 01),  Price = 2000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2018, 01, 01), Price = -1000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2019, 01, 01), Price = -3000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2020, 01, 01),   Price = 4000 },
                new AreaNegativeChartData { Vegetable = new DateTime(2021, 01, 01), Price = 1000 }
            };
            ViewData["MaryValues"] = MaryValues;
            ViewData["PatriciaValues"] = PatriciaValues;
            ViewData["LindaValues"] = LindaValues;
            return View();
        }
        public class AreaNegativeChartData
        {
            public DateTime Vegetable;
            public double Price;
        }
    }
}