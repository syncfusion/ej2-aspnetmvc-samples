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
        // GET: PolarRadarRangeColumn
        public ActionResult PolarRadarRangeColumn()
        {
            List<PolarRangeColumnData> data = new List<PolarRangeColumnData>
            {
                new PolarRangeColumnData { x= "Jan", low= 2, high= 7 },
                new PolarRangeColumnData { x= "Feb", low= 3, high= 7 },
                new PolarRangeColumnData { x= "Mar", low= 3, high= 7 },
                new PolarRangeColumnData { x= "Apr", low= 4, high= 9 },
                new PolarRangeColumnData { x= "May", low= 6, high= 11 },
                new PolarRangeColumnData { x= "June", low= 8, high= 14 }
            };
            ViewBag.dataSource = data;
            ViewBag.data = new string[] { "Polar", "Radar" };
            return View();
        }
        public class PolarRangeColumnData
        {
            public string x;
            public double low;
            public double high;
        }
    }
}