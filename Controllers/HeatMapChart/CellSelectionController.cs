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

namespace EJ2MVCSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        // GET: CellSelection
        public ActionResult CellSelection()
        {
            string[] xlabels = new string[7] { "Cereals", "Meat", "Spices", "Tea", "Edible Oil", "Dairy Products", "Wheat" };
            ViewData["xLabels"] = xlabels;
            ViewData["textStyle"] = new
            {
                size= "15px",
                fontWeight= "500",
                fontStyle= "Normal",
                fontFamily = "inherit"
            };
            ViewData["labelTextStyle"] = new
            {
                fontFamily = "inherit"
            };
            string[] yLabels = new string[5] { "2014", "2015", "2016", "2017", "2018" };
            ViewData["yLabels"] = yLabels;
            double[,] dataSource = new double[,]
            {
                {2.9, 5.2, 3.4, 5.6, 4.4 },
                {6.6, 4.8, 8, 3.9, 6.5},
                {5.1, 4.6, 5.4, 3.9, 4.3},
                {5.2, 4.3, 3.9, 6.2, 6.4},
                {7, 3, 1.9, 5.9, 3.5},
                {7.8, 5.9, 3.9, 4.3, 4.3},
                {6.5, 4.3, 3.9, 5.2, 3.9}
            };
            ViewData["dataSource"] = dataSource;
            List<ChartData> chartData = new List<ChartData>
            {
               new ChartData { x= "2014", y = 2.9 },
               new ChartData { x= "2015", y = 5.2 },
               new ChartData { x= "2016", y = 3.4 },
               new ChartData { x= "2017", y = 5.6 },
               new ChartData { x= "2018", y = 4.4 }
            };
            ViewData["dataSource1"] = chartData;
            List<ChartData> chartData1 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 6.6 },
               new ChartData { x= "2015", y = 4.8 },
               new ChartData { x= "2016", y = 8 },
               new ChartData { x= "2017", y = 3.9 },
               new ChartData { x= "2018", y = 6.5 }
            };
            ViewData["dataSource2"] = chartData1;
            List<ChartData> chartData2 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 5.1 },
               new ChartData { x= "2015", y = 4.6 },
               new ChartData { x= "2016", y = 5.4 },
               new ChartData { x= "2017", y = 3.9 },
               new ChartData { x= "2018", y = 4.3 }
            };
            ViewData["dataSource3"] = chartData2;
            List<ChartData> chartData3 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 5.2 },
               new ChartData { x= "2015", y = 4.3 },
               new ChartData { x= "2016", y = 3.9 },
               new ChartData { x= "2017", y = 6.2 },
               new ChartData { x= "2018", y = 6.4 }
            };
            ViewData["dataSource4"] = chartData3;
            List<ChartData> chartData4 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 7 },
               new ChartData { x= "2015", y = 3 },
               new ChartData { x= "2016", y = 1.9 },
               new ChartData { x= "2017", y = 5.9 },
               new ChartData { x= "2018", y = 3.5 }
            };
            ViewData["dataSource5"] = chartData4;
            List<ChartData> chartData5 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 7.8 },
               new ChartData { x= "2015", y = 5.9 },
               new ChartData { x= "2016", y = 3.9 },
               new ChartData { x= "2017", y = 4.3 },
               new ChartData { x= "2018", y = 4.5 }
            };
            ViewData["dataSource6"] = chartData5;
            List<ChartData> chartData6 = new List<ChartData>
            {
               new ChartData { x= "2014", y = 6.5 },
               new ChartData { x= "2015", y = 4.3 },
               new ChartData { x= "2016", y = 3.9 },
               new ChartData { x= "2017", y = 5.2 },
               new ChartData { x= "2018", y = 3.9 }
            };
            ViewData["dataSource7"] = chartData6;
            
            return View();
        }
        public class ChartData
        {
            public string x;
            public double y;
        }
    }
}