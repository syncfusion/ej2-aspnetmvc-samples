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
        // GET: SmartAxisLabels
        public ActionResult SmartAxisLabels()
        {
            List<SmartAxisLabelsChartData> ChartPoints = new List<SmartAxisLabelsChartData>
            {
                new SmartAxisLabelsChartData { Country = "South Korea",  User = 39, DataLabelMappingName = "39M" },
                new SmartAxisLabelsChartData { Country = "India",        User = 61, DataLabelMappingName = "61M" },
                new SmartAxisLabelsChartData { Country = "Pakistan",     User = 20, DataLabelMappingName = "20M" },
                new SmartAxisLabelsChartData { Country = "Germany",      User = 65, DataLabelMappingName = "65M" },
                new SmartAxisLabelsChartData { Country = "Australia",    User = 16, DataLabelMappingName = "16M" },
                new SmartAxisLabelsChartData { Country = "Italy",        User = 29, DataLabelMappingName = "29M" },
                new SmartAxisLabelsChartData { Country = "France",       User = 45, DataLabelMappingName = "45M" },
                new SmartAxisLabelsChartData { Country = "United Arab Emirates", User = 10, DataLabelMappingName = "10M" },
                new SmartAxisLabelsChartData { Country = "Russia",       User = 41, DataLabelMappingName = "41M" },
                new SmartAxisLabelsChartData { Country = "Mexico",       User = 31, DataLabelMappingName = "31M" },
                new SmartAxisLabelsChartData { Country = "Brazil",       User = 76, DataLabelMappingName = "76M" },
                new SmartAxisLabelsChartData { Country = "China",        User = 51, DataLabelMappingName = "51M" }

            };
            ViewData["ChartPoints"] = ChartPoints;
            ViewData["font"] = new { fontWeight = "600", color = "#ffffff" };
            ViewData["data"] = new string[] { "Hide", "Trim", "Wrap", "MultipleRows", "Rotate45", "Rotate90", "None" };
            ViewData["data1"] = new string[] { "None", "Hide", "Shift" };
            ViewData["data2"] = new string[] { "Outside", "Inside" };
            return View();
        }
        public class SmartAxisLabelsChartData
        {
            public string Country;
            public double User;
            public string DataLabelMappingName;
        }
    }
}