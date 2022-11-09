#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
        // GET: SmartLabels
        public ActionResult SmartLabels()
        {
            List<SmartLabelsChartData> chartData = new List<SmartLabelsChartData>
            {

                new SmartLabelsChartData { xValue = "USA",          yValue = 46, text = "United States of America: 46" },
                new SmartLabelsChartData { xValue = "China",        yValue = 26, text = "China: 26" },
                new SmartLabelsChartData { xValue = "Russia",       yValue = 19, text = "Russia: 19" },
                new SmartLabelsChartData { xValue = "Germany",      yValue = 17, text = "Germany: 17" },
                new SmartLabelsChartData { xValue = "Japan",        yValue = 12, text = "Japan: 12" },
                new SmartLabelsChartData { xValue = "France",       yValue = 10, text = "France: 10" },
                new SmartLabelsChartData { xValue = "South Korea",  yValue = 9,  text = "South Korea: 9" },
                new SmartLabelsChartData { xValue = "Great Britain",yValue = 27, text = "Great Britain: 27" },
                new SmartLabelsChartData { xValue = "Italy",        yValue = 8,  text = "Italy: 8" },
                new SmartLabelsChartData { xValue = "Australia",    yValue = 8,  text = "Australia: 8" },
                new SmartLabelsChartData { xValue = "Netherlands",  yValue = 8,  text = "Netherlands: 8" },
                new SmartLabelsChartData { xValue = "NewZealand",   yValue = 4,  text = "New Zealand: 4" },
                new SmartLabelsChartData { xValue = "Uzbekistan",   yValue = 4,  text = "Uzbekistan: 4" },
                new SmartLabelsChartData { xValue = "Kazakhstan",   yValue = 3,  text = "Kazakhstan: 3" },
                new SmartLabelsChartData { xValue = "Colombia",     yValue = 3,  text = "Colombia: 3" },
                new SmartLabelsChartData { xValue = "Switzerland",  yValue = 3,  text = "Switzerland: 3" },
                new SmartLabelsChartData { xValue = "Argentina",    yValue = 3,  text = "Argentina: 3" },
                new SmartLabelsChartData { xValue = "South Africa", yValue = 2,  text = "South Africa: 2" },
                new SmartLabelsChartData { xValue = "North Korea",  yValue = 2,  text = "North Korea: 2" }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class SmartLabelsChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}