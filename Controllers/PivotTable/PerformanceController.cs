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
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotTableController : Controller
    {

        public ActionResult Performance()
        {
            ViewData["performanceOptions"] = new PerformanceOptions1().GetPerformanceOptions();
            return View();
        }

        public class PerformanceOptions1
        {
            public string text { get; set; }

            public int value { get; set; }

            public List<PerformanceOptions1> GetPerformanceOptions()
            {
                List<PerformanceOptions1> performanceOptions = new List<PerformanceOptions1>();
                performanceOptions.Add(new PerformanceOptions1 { text = "10,000 Rows and 10 Columns", value = 10000 });
                performanceOptions.Add(new PerformanceOptions1 { text = "1,00,000 Rows and 10 Columns", value = 100000 });
                performanceOptions.Add(new PerformanceOptions1 { text = "1,000,000 Rows and 10 Columns", value = 1000000 });
                return performanceOptions;
            }
        }
    }
}

