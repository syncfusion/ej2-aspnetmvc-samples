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

namespace EJ2MVCSampleBrowser.Controllers.ThreeDimensionalChart
{
    public partial class ThreeDimensionalChartController : Controller
    {
        // GET: StackedColumn
        public ActionResult StackedColumn100()
        {
            List<Stacked100Data> ChartPoints = new List<Stacked100Data>
            {
                new Stacked100Data { X = "2013", Y = 9628912, Y1 = 4298390, Y2 = 2842133, Y3 = 2006366 },
                new Stacked100Data { X = "2014", Y = 9609326, Y1 = 4513769, Y2 = 3016710, Y3 = 2165566  },
                new Stacked100Data { X = "2015", Y = 7485587, Y1 = 4543838, Y2 = 3034081, Y3 = 2279503 },
                new Stacked100Data { X = "2016", Y = 7793066, Y1 = 4999266, Y2 = 2945295, Y3 = 2359756 },
                new Stacked100Data { X = "2017", Y = 6856880, Y1 = 5235842, Y2 = 3302336, Y3 = 2505741 }
            };
            
            ViewData["ChartData"] = ChartPoints;
            return View();
        }
        public class Stacked100Data
        {
            public string X;
            public double Y;
            public double Y1;
            public double Y2;
            public double Y3;
        }
    }
}