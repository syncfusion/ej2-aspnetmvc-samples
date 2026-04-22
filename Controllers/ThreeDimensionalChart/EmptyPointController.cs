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
        public ActionResult EmptyPoint()
        {
            List<EmptyData> ChartPoints = new List<EmptyData>
            {
                new EmptyData { X = "Italy", Y = 10 },
                new EmptyData { X = "Kenya", Y = 4 },
                new EmptyData { X = "France", Y = 10  },
                new EmptyData { X = "Hungary", Y = 0 },
                new EmptyData { X = "Australia", Y = 17  },
                new EmptyData { X = "Brazil", Y = 7  },
                new EmptyData { X = "Netherlands", Y = 10  },
                new EmptyData { X = "Unspecified", Y = null  },
                new EmptyData { X = "Germany", Y = 10  },
                new EmptyData { X = "Serbia", Y = 3  }
            };
            
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class EmptyData
        {
            public string X;
            public double? Y;
        }
    }
}