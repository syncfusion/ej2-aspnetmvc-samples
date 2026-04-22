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
        // GET: StackedColumn
        public ActionResult StackedColumn()
        {
            List<StackedData> ChartPoints = new List<StackedData>
            {
                new StackedData { X = "2018", Y = 24.5, Y1 = 6.2, Y2 = 24.5, Y3 = 15.4 },
                new StackedData { X = "2019", Y = 25.6, Y1 = 15.6, Y2 = 23.2, Y3 = 21.1  },
                new StackedData { X = "2020", Y = 29, Y1 = 14.3, Y2 = 20.4, Y3 = 13.9 },
                new StackedData { X = "2021", Y = 28.5, Y1 = 9.3, Y2 = 23.2, Y3 = 11.6 },
                new StackedData { X = "2022", Y = 30.6, Y1 = 7.8, Y2 = 24.5, Y3 = 14.4 }
            };
            
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class StackedData
        {
            public string X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }
    }
}