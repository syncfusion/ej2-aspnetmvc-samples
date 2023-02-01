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
        // GET: Print
        public ActionResult Print()
        {
            List<PrintChartData> chartData = new List<PrintChartData>
            {
                new PrintChartData { xValue = "John",  yValue = 10000 },
                new PrintChartData { xValue = "Jake",  yValue = 12000 },
                new PrintChartData { xValue = "Peter", yValue = 18000 },
                new PrintChartData { xValue = "James", yValue = 11000 },
                new PrintChartData { xValue = "Mary",  yValue = 9700  }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PrintChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}