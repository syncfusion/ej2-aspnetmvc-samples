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
        // GET: Selection
        public ActionResult Selection()
        {
            List<SelectionChartData> ChartPoints = new List<SelectionChartData>
            {
                new SelectionChartData { Country = "China", Children = 17, Adult = 54, SeniorAdult = 9  },
                new SelectionChartData { Country = "USA", Children = 19, Adult = 67, SeniorAdult = 14 },
                new SelectionChartData { Country = "India", Children = 29, Adult = 65, SeniorAdult = 6  },
                new SelectionChartData { Country = "Japan", Children = 13, Adult = 61, SeniorAdult = 26 },
                new SelectionChartData { Country = "Brazil", Children = 24, Adult = 68, SeniorAdult = 8  }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class SelectionChartData
        {
            public string Country;
            public double Children;
            public double Adult;
            public double SeniorAdult;
        }
    }
}