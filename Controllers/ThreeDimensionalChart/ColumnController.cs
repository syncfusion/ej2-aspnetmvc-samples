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
        public ActionResult Column()
        {
            List<ColumnChart> ChartPoints = new List<ColumnChart>
            {
                new ColumnChart { X = "Tesla",    Y = 137429 },
                new ColumnChart { X = "Aion",     Y = 80308  },
                new ColumnChart { X = "Wuling",   Y = 76418  },
                new ColumnChart { X = "Changan",  Y = 52849  },
                new ColumnChart { X = "Geely",    Y = 47234  },
                new ColumnChart { X = "Nio",      Y = 31041  },
                new ColumnChart { X = "Neta",     Y = 22449  },
                new ColumnChart { X = "BMW",      Y = 18733  }
            };           
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class ColumnChart
        {
            public string X;
            public double Y;
        }
    }
}