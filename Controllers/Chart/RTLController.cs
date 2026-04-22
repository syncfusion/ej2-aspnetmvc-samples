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
        // GET: Trendlines
        public ActionResult RTL()
        {
            List<RTLData> ChartPoints = new List<RTLData>
            {
                new RTLData { Year = 2016, Sales = 1000, Expense = 400, Profit = 600 },
                new RTLData { Year = 2017, Sales = 970, Expense = 360, Profit = 610 },
                new RTLData { Year = 2018, Sales = 1060, Expense = 920, Profit = 140 },
                new RTLData { Year = 2019, Sales = 1030, Expense = 540, Profit = 490 }
            };
            ViewData["ChartPoints"] = ChartPoints;
            return View();
        }
        public class RTLData
        {
            public double Year;
            public double Sales;
            public double Expense;
            public double Profit;
        }
    }
}