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
        // GET: Doughnut
        public ActionResult Doughnut()
        {
            List<DoughnutChartData> chartData = new List<DoughnutChartData>
            {
                new DoughnutChartData { xValue = "Labour", yValue = 18, text = "18%"},
                new DoughnutChartData { xValue = "Legal", yValue = 8 , text = "8% "},
                new DoughnutChartData { xValue = "Production", yValue = 15, text = "15%"},
                new DoughnutChartData { xValue = "License", yValue = 11, text = "11%"},
                new DoughnutChartData { xValue = "Facilities", yValue = 18, text = "18%"},
                new DoughnutChartData { xValue = "Taxes", yValue = 14, text = "14%"},
                new DoughnutChartData { xValue = "Insurance", yValue = 16, text = "16%"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class DoughnutChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }
    }
}