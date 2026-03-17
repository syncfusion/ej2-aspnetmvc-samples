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
        // GET: Column
        public ActionResult BackToBack()
        {
            List<ColumnChartData> ChartPoints = new List<ColumnChartData>
            {
                new ColumnChartData { X = "Jamesh",  Y = 1 },
                new ColumnChartData { X = "Michael", Y = 2 },
                new ColumnChartData { X = "John",    Y = 2 },
                new ColumnChartData { X = "Jack",    Y = 1 },
                new ColumnChartData { X = "Lucas",   Y = 1 }
            };
            List<ColumnChartData> ChartPoints1 = new List<ColumnChartData>
            {
                new ColumnChartData { X = "Jamesh",  Y = 4 },
                new ColumnChartData { X = "Michael", Y = 3 },
                new ColumnChartData { X = "John",    Y = 4 },
                new ColumnChartData { X = "Jack",    Y = 2 },
                new ColumnChartData { X = "Lucas",   Y = 3 }
            };
            List<ColumnChartData> ChartPoints2 = new List<ColumnChartData>
            {
                new ColumnChartData { X = "Jamesh",  Y = 5 },
                new ColumnChartData { X = "Michael", Y = 4 },
                new ColumnChartData { X = "John",    Y = 5 },
                new ColumnChartData { X = "Jack",    Y = 5 },
                new ColumnChartData { X = "Lucas",   Y = 6 }
            };
            List<ColumnChartData> ChartPoints3 = new List<ColumnChartData>
            {
                new ColumnChartData { X = "Jamesh",  Y = 10, Text = "Total 10" },
                new ColumnChartData { X = "Michael", Y = 9,  Text = "Total 9"  },
                new ColumnChartData { X = "John",    Y = 11, Text = "Total 11" },
                new ColumnChartData { X = "Jack",    Y = 8,  Text = "Total 8"  },
                new ColumnChartData { X = "Lucas",   Y = 10, Text = "Total 10" }
            };
            ViewData["Grapes"] = ChartPoints;
            ViewData["Orange"] = ChartPoints1;
            ViewData["Apple"] = ChartPoints2;
            ViewData["Total"] = ChartPoints3;
            return View();
        }
        public class ColumnChartData
        {
            public string X;
            public double Y;
            public string Text;
        }
    }
}