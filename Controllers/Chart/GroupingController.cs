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
        // GET: Grouping
        public ActionResult Grouping()
        {
            List<GroupingChartData> ChartPoints = new List<GroupingChartData>
            {
                new GroupingChartData { Country = "China",         Medal = 40, DataLabelMappingName = "China: 40" },
                new GroupingChartData { Country = "Japan",         Medal = 20, DataLabelMappingName = "Japan: 20" },
                new GroupingChartData { Country = "Australia",     Medal = 18, DataLabelMappingName = "Australia: 18" },
                new GroupingChartData { Country = "France",        Medal = 16, DataLabelMappingName = "France: 16" },
                new GroupingChartData { Country = "Netherlands",   Medal = 15, DataLabelMappingName = "Netherlands: 15" },
                new GroupingChartData { Country = "Great Britain", Medal = 14, DataLabelMappingName = "Great Britain: 14" },
                new GroupingChartData { Country = "South Korea",   Medal = 13, DataLabelMappingName = "South Korea: 13" },
                new GroupingChartData { Country = "Germany",       Medal = 12, DataLabelMappingName = "Germany: 12" },
                new GroupingChartData { Country = "Italy",         Medal = 12, DataLabelMappingName = "Italy: 12" },
                new GroupingChartData { Country = "Canada",        Medal = 9,  DataLabelMappingName = "Canada: 9" },
                new GroupingChartData { Country = "Hungary",       Medal = 6,  DataLabelMappingName = "Hungary: 6" },
                new GroupingChartData { Country = "Spain",         Medal = 5,  DataLabelMappingName = "Spain: 5" },
                new GroupingChartData { Country = "Kenya",         Medal = 4,  DataLabelMappingName = "Kenya: 4" },
                new GroupingChartData { Country = "Brazil",        Medal = 3,  DataLabelMappingName = "Brazil: 3" }
            };
            bool isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {
                ChartPoints[1].DataLabelMappingName = "Japan:<br> 20";
                ChartPoints[2].DataLabelMappingName = "Australia:<br> 18";
                ChartPoints[7].DataLabelMappingName = "Germany:<br> 12";
                ChartPoints[8].DataLabelMappingName = "Italy:<br> 12";
                ChartPoints[9].DataLabelMappingName = "CA: 9";
                ChartPoints[10].DataLabelMappingName = "HU: 6";
            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["data"] = new string[] { "Point", "Value" };
            return View();
        }
        public class GroupingChartData
        {
            public string Country;
            public double Medal;
            public string DataLabelMappingName;
        }
    }
}