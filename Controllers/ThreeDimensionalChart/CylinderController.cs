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
        // GET: Cylinder
        public ActionResult Cylinder()
        {
            List<ColumnData> ChartPoints = new List<ColumnData>
            {
                new ColumnData { X = "Czechia", Y = 1.11  },
                new ColumnData { X = "Spain", Y = 1.66 },
                new ColumnData { X = "USA", Y = 1.56  },
                new ColumnData { X = "Germany", Y = 3.1  },
                new ColumnData { X = "Russia", Y = 1.35  },
                new ColumnData { X = "Slovakia", Y = 1 },
                new ColumnData { X = "South Korea", Y = 3.16  },
                new ColumnData { X = "France", Y = 0.96 }
            };
            
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class ColumnData
        {
            public string X;
            public double Y;
        }
    }
}