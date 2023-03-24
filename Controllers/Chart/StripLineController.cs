#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
        // GET: StripLine
        public ActionResult StripLine()
        {
            List<StripLineChartData> WeatherReportsA = new List<StripLineChartData>
            {
               new StripLineChartData { Day = "Jan", Temperature = 90 },
               new StripLineChartData { Day = "Feb", Temperature = 92 },
               new StripLineChartData { Day = "Mar", Temperature = 94 },
               new StripLineChartData { Day = "Apr", Temperature = 95 },
               new StripLineChartData { Day = "May", Temperature = 94 },
               new StripLineChartData { Day = "Jun", Temperature = 96 },
               new StripLineChartData { Day = "Jul", Temperature = 97 },
               new StripLineChartData { Day = "Aug", Temperature = 98 },
               new StripLineChartData { Day = "Sep", Temperature = 97 },
               new StripLineChartData { Day = "Oct", Temperature = 95 },
               new StripLineChartData { Day = "Nov", Temperature = 90 },
               new StripLineChartData { Day = "Dec", Temperature = 95 }
            };
            ViewBag.WeatherReportsA = WeatherReportsA;
            List<StripLineChartData> WeatherReportsB = new List<StripLineChartData>
            {
                new StripLineChartData { Day = "Jan", Temperature = 85 },
                new StripLineChartData { Day = "Feb", Temperature = 86 },
                new StripLineChartData { Day = "Mar", Temperature = 87 },
                new StripLineChartData { Day = "Apr", Temperature = 88 },
                new StripLineChartData { Day = "May", Temperature = 87 },
                new StripLineChartData { Day = "Jun", Temperature = 90 },
                new StripLineChartData { Day = "Jul", Temperature = 91 },
                new StripLineChartData { Day = "Aug", Temperature = 90 },
                new StripLineChartData { Day = "Sep", Temperature = 93 },
                new StripLineChartData { Day = "Oct", Temperature = 90 },
                new StripLineChartData { Day = "Nov", Temperature = 85 },
                new StripLineChartData { Day = "Dec", Temperature = 90 }
            };
            ViewBag.WeatherReportsB = WeatherReportsB;
            List<StripLineChartData> WeatherReportsC = new List<StripLineChartData>
            {
                new StripLineChartData { Day = "Jan", Temperature = 80 },
                new StripLineChartData { Day = "Feb", Temperature = 81 },
                new StripLineChartData { Day = "Mar", Temperature = 82 },
                new StripLineChartData { Day = "Apr", Temperature = 83 },
                new StripLineChartData { Day = "May", Temperature = 84 },
                new StripLineChartData { Day = "Jun", Temperature = 83 },
                new StripLineChartData { Day = "Jul", Temperature = 82 },
                new StripLineChartData { Day = "Aug", Temperature = 81 },
                new StripLineChartData { Day = "Sep", Temperature = 85 },
                new StripLineChartData { Day = "Oct", Temperature = 84 },
                new StripLineChartData { Day = "Nov", Temperature = 83 },
                new StripLineChartData { Day = "Dec", Temperature = 82 }
            };
            ViewBag.WeatherReportsC = WeatherReportsC;
            return View();
        }
        public class StripLineChartData
        {
            public string Day;
            public double Temperature;
        }
    }
}