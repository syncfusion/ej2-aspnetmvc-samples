#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public ActionResult AccumulationLegendTemplate()
        {
            var pieChartPoints = new List<PieLegendTemplateData>
            {
                new PieLegendTemplateData { X = "United States", Y = 29.55, Text = "United States: 29.55%", Description = "13.4M barrels per day", Tooltip = "13.4M" },
                new PieLegendTemplateData { X = "Saudi Arabia",  Y = 23.83, Text = "Saudi Arabia: 23.83%",  Description = "10.8M barrels per day", Tooltip = "10.8M" },
                new PieLegendTemplateData { X = "Russia",        Y = 23.69, Text = "Russia: 23.69%",        Description = "10.8M barrels per day", Tooltip = "10.8M" },
                new PieLegendTemplateData { X = "Canada",        Y = 12.12, Text = "Canada: 12.12%",        Description = "5.5M barrels per day",  Tooltip = "5.5M"  },
                new PieLegendTemplateData { X = "China",         Y = 10.83, Text = "China: 10.83%",         Description = "4.9M barrels per day",  Tooltip = "4.9M"  }
            };

            ViewBag.TitleText = "Top 5 Oil Producing Countries (2023)";
            ViewBag.SubTitle = "Source: Wikipedia.org";
            ViewData["PieChartPoints"] = pieChartPoints;

            return View();
        }

        public class PieLegendTemplateData
        {
            public string X { get; set; }
            public double Y { get; set; }
            public string Text { get; set; }
            public string Description { get; set; }
            public string Tooltip { get; set; }
        }
    }
}