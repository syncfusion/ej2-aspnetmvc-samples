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
        // GET: VerticalChart
        public ActionResult VerticalChart()
        {
            List<VerticalChartData> chartPoints = new List<VerticalChartData>
            {
                new VerticalChartData {Year = "2016", column =13600, series =0.5 },
                new VerticalChartData {Year = "2017", column =12900, series =1.5 },
                new VerticalChartData {Year = "2018", column =12500, series =3.5 },
                new VerticalChartData {Year = "2019", column =14500, series =1.5 },
                new VerticalChartData {Year = "2020", column =14500, series =3 },
                new VerticalChartData {Year = "2021", column =12000, series =2.5 }
            };
            ViewData["chartPoints"] = chartPoints;
            return View();
        }
        public class VerticalChartData
        {
            public string Year;
            public double column;
            public double series;
        }
    }
}