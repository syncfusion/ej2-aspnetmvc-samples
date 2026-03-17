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
        // GET: Drilldown
        public ActionResult Drilldown()
        {

            List<DrilldownData> chartData = new List<DrilldownData>
            {
                new DrilldownData { x = "Asia-Pacific", y = 45 },
                new DrilldownData { x = "Europe", y = 25 },
                new DrilldownData { x = "North America", y = 25 },
                new DrilldownData { x = "Latin America", y = 7 },
                new DrilldownData { x = "Middle East & Africa", y = 3 }
            };
            ViewData["dataSource"] = chartData;
            return View();
        }
    }
    public class DrilldownData
    {
        public string x;
        public double y;
    }

}
