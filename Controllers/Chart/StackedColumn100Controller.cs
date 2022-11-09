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
        // GET: StackedColumn100
        public ActionResult StackedColumn100()
        {
            List<StackedColumnChartData100> chartData = new List<StackedColumnChartData100>
            {
                 new StackedColumnChartData100 { x= "2006", y= 900, y1= 190, y2= 250, y3= 150 },
                 new StackedColumnChartData100 { x= "2007", y= 544, y1= 226, y2= 145, y3= 120 },
                 new StackedColumnChartData100 { x= "2008", y= 880, y1= 194, y2= 190, y3= 115 },
                 new StackedColumnChartData100 { x= "2009", y= 675, y1= 250, y2= 220, y3= 125 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class StackedColumnChartData100
        {
            public string x;
            public double y;
            public double y1;
            public double y2;
            public double y3;
        }
    }
}